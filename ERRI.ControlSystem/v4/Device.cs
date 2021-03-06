﻿using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Drawing;
using EERIL.ControlSystem.Avt;
using EERIL.ControlSystem.Test;
using System.Windows.Threading;
using System.Text;
using System.Drawing.Imaging;
using EERIL.ControlSystem.Properties;
using System.Runtime.CompilerServices;
using System.IO;
using PvNET;

namespace EERIL.ControlSystem.v4 {
	[ControlSystem.Device("MsledOS", OsVersion = new double[] { 4 })]
	class Device : IDevice {
		private readonly ICamera camera;
		private string displayName = null;
		private readonly Thread serialMonitorThread;
		private readonly Settings settings = Settings.Default;
		private readonly List<byte> buffer = new List<byte>();
		private byte horizontalFinPosition = 90;
		private byte verticalFinPosition = 90;
        private byte focusPosition = 51;
		private byte topFinOffset = 90;
		private byte rightFinOffset = 90;
		private byte bottomFinOffset = 90;
		private byte leftFinOffset = 90;
		private byte finRange = 64;
		private byte thrust = 90;
		private byte illumination = 155;
        private bool turbo = false;
        private byte buoyancyPosition = 81;
        public bool tinvert = false;
        
		private PowerConfigurations powerConfiguration;
		public event DeviceFrameReadyHandler FrameReady;
		public event DeviceMessageHandler MessageReceived;
        

		public uint Id
		{
			get { return camera.Reference; }
		}

		public string DisplayName {
			get {
				return displayName ?? camera.DisplayName;
			}
		}

		public IList<ITest> Tests
		{
			get
			{
				return new List<ITest>()
				{
					new PowerTest(this)
				};
			}
		}

		public IList<ISensor> Sensors { get { return null; } }

		public uint ImageHeight {
			get {
				return this.camera.ImageFormat.height;
			}
			set
			{
				this.camera.ImageFormat.height = value;
			}
		}

		public uint ImageWidth {
			get {
				return this.camera.ImageFormat.width;
			}
			set
			{
				this.camera.ImageFormat.width = value;
			}
		}

		public uint ImageDepth {
			get {
				return this.camera.ImageFormat.GetDepth();
			}
		}

		public float BytesPerPixel
		{
			get
			{
				return this.camera.ImageFormat.GetBytesPerPixel();
			}
		}

		public float FrameRate
		{
			get
			{
				return this.camera.FrameRate;
			}
			set
			{
				this.camera.FrameRate = value;
			}
		}

		public tImageFormat PixelFormat
		{
			get {
				return this.camera.ImageFormat.pixelformat;
			}
			set
			{
				this.camera.ImageFormat.pixelformat = value;
			}
		}

		public byte HorizontalFinPosition {
			get { return horizontalFinPosition; }
			set
			{
				value = EnforceFinRange(value);
				if(!camera.WriteBytesToSerial(new byte[] { 0x68, value, 0x0D }))
				{
					throw new Exception("Failed to transmit horizontal fin position to device.");
				}
				horizontalFinPosition = value;
			}
		}

		public byte VerticalFinPosition {
			get { return verticalFinPosition; }
			set
			{
				value = EnforceFinRange(value);
				if (!camera.WriteBytesToSerial(new byte[] { 0x76, value, 0x0D }))
				{
					throw new Exception("Failed to transmit vertical fin position to device.");
				}
				verticalFinPosition = value;
			}
		}

        public byte FocusPosition
        {
            get { return focusPosition; }
            set
            {
                if (!camera.WriteBytesToSerial(new byte[] { 0x66, value, 0x0D }))
                {
                    throw new Exception("Failed to transmit focus position to device.");
                }
                focusPosition = value;
            }
        }

        public byte BuoyancyPosition
        {
            get { return buoyancyPosition; }
            set
            {
                if (!camera.WriteBytesToSerial(new byte[] { 0x62, value, 0x0D }))
                {
                    throw new Exception("Failed to transmit buoyancy position to device.");
                }
                buoyancyPosition = value;
            }
        }

		public byte TopFinOffset
		{
			get { return topFinOffset; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x61, 0x74, value, 0x0D }))
				{
					throw new Exception("Failed to transmit top fin offset.");
				}
				topFinOffset = value;
			}
		}

		public byte RightFinOffset
		{
			get { return rightFinOffset; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x61, 0x72, value, 0x0D }))
				{
					throw new Exception("Failed to transmit right fin offset.");
				}
				rightFinOffset = value;
			}
		}

		public byte BottomFinOffset
		{
			get { return bottomFinOffset; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x61, 0x62, value, 0x0D }))
				{
					throw new Exception("Failed to transmit bottom fin offset.");
				}
				bottomFinOffset = value;
			}
		}

		public byte LeftFinOffset
		{
			get { return leftFinOffset; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x61, 0x6C, value, 0x0D }))
				{
					throw new Exception("Failed to transmit left fin offset.");
				}
				leftFinOffset = value;
			}
		}

		public byte FinRange
		{
			get { return finRange; }
			set
			{
				finRange = value;
				HorizontalFinPosition = horizontalFinPosition;
				VerticalFinPosition = verticalFinPosition;
			}
		}

		public bool Turbo {
            get { return turbo; }
            set { turbo = value; }
		}

        public bool Tinvert
        {
            get { return tinvert; }
            set { tinvert = value; }
        }


		public byte Thrust {
			get {
                   return thrust;
                }
			set {
                if (Tinvert)
                {
                    if (Turbo)
                    {
                        camera.WriteBytesToSerial(new byte[] { 0x74, Convert.ToByte(0 - value), 0x0D });
                    }
                    else
                        camera.WriteBytesToSerial(new byte[] { 0x74, Convert.ToByte((90-value) /2 + 90), 0x0D });
                }
                else
                {
                    if (Turbo)
                    {
                        camera.WriteBytesToSerial(new byte[] { 0x74, Convert.ToByte(value), 0x0D });
                    }
                    else
                        camera.WriteBytesToSerial(new byte[] { 0x74, Convert.ToByte((value - 90) / 2 + 90), 0x0D });
                }
				
                thrust = value;
            }
		}

		public byte Illumination
		{
			get { return illumination; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x69, value, 0x0D }))
				{
					throw new Exception("Failed to transmit illumination.");
				} 
				illumination = value;
			}
		}

		public PowerConfigurations PowerConfiguration {
			get { return powerConfiguration; }
			set
			{
				if (!camera.WriteBytesToSerial(new byte[] { 0x70, (byte)value, 0x0D }))
				{
					throw new Exception("Failed to transmit power configuration.");
				}
				powerConfiguration = value;
			}
		}

		ICamera Camera {
			get {
				return camera;
			}
		}

		public Device(string displayName) {
			this.displayName = displayName;
		}

		public Device(ICamera camera) {
			this.camera = camera;
			this.camera.FrameReady += CameraFrameReady;
			serialMonitorThread = new Thread(MonitorSerialCommunication);
			serialMonitorThread.Name = "Serial Communication Monitor";
			serialMonitorThread.IsBackground = true;
			serialMonitorThread.Priority = ThreadPriority.BelowNormal;
		}

		private byte EnforceFinRange(byte value)
		{
			int adjustedValue = value - 90,
				invertedRange;
			byte result;
			if (adjustedValue > FinRange)
			{
				result = (byte)(FinRange + 90);
			}
			else if (adjustedValue < (invertedRange = FinRange * -1))   
			{
				result = (byte)(invertedRange + 90);
			} else
			{
				result = value;
			}
			return result;
		}

		private void CameraFrameReady(object sender, IFrame frame) {
			OnFrameReady(frame);
		}

		protected void OnFrameReady(IFrame frame) {
			if (FrameReady != null) {
				DeviceFrameReadyHandler eventHandler = FrameReady;
				Delegate[] delegates = eventHandler.GetInvocationList();
				foreach (DeviceFrameReadyHandler handler in delegates) {
					DispatcherObject dispatcherObject = handler.Target as DispatcherObject;
					if (dispatcherObject != null && !dispatcherObject.CheckAccess()) {
						dispatcherObject.Dispatcher.Invoke(DispatcherPriority.DataBind, handler, this, frame);
					} else
						handler(this, frame);
				}
			}
		}

		protected void OnMessageReceived(byte[] message)
		{
			if (MessageReceived != null) {
				DeviceMessageHandler eventHandler = MessageReceived;
				Delegate[] delegates = eventHandler.GetInvocationList();
				foreach (DeviceMessageHandler handler in delegates) {
					DispatcherObject dispatcherObject = handler.Target as DispatcherObject;
					if (dispatcherObject != null && !dispatcherObject.CheckAccess()) {
						dispatcherObject.Dispatcher.Invoke(DispatcherPriority.DataBind, handler, this, message);
					} else
						handler(this, message);
				}
			}
		}

		public void StartVideoCapture(uint timeout) {
			this.camera.Open();
			this.camera.AdjustPacketSize();
			this.camera.BeginCapture(tImageFormat.eFmtBayer8);
		}

		public void StopVideoCapture() {
			this.camera.EndCapture();
			this.camera.Close();
		}

		public void PrepareForGrab(ref uint dcamMode, ref uint colorCode, ref uint width, ref uint height) {
			//Todo: fix me.
			/*enUniColorCode colorCodeEn = (enUniColorCode)colorCode;
			this.camera.PrepareFreeGrab(ref dcamMode, ref colorCodeEn, ref width, ref height);
			colorCode = (uint)colorCodeEn;*/
		}

		public void GetImage(Bitmap bitmap, uint timeout) {
			//Todo: fix me.
			//this.camera.GetImage(bitmap, timeout);
		}

		private void MonitorSerialCommunication() {
			byte[] buffer = new byte[settings.SerialReceiveInputBufferSize];
			uint length = 0;
				while (true)
				{
					lock (buffer)
					{
						if (camera.ReadBytesFromSerial(buffer, ref length) && length > 0)
						{
							ParseSerial(buffer, length);
						}
					}
					Thread.Yield();
				}
		}

		private void ParseSerial(byte[] array, uint length) {
			for (int i = 0; i < length; i++)
			{
				if (array[i] != 0x0D)
				{
					buffer.Add(array[i]);
				}
				else if(buffer.Count > 0)
				{
					byte[] message = buffer.ToArray();
					buffer.Clear();
					OnMessageReceived(message);
				}
			}
		}

		public void Open()
		{
			this.camera.Open();
			serialMonitorThread.Start();
		}

		public void Close()
		{
			serialMonitorThread.Abort();
			this.camera.Close();
		}

		#region IDisposable Members

		public void Dispose() {
			this.camera.Close();
		}

		#endregion
	}
}
