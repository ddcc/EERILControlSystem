﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EERIL.ControlSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Msled\\Missions")]
        public string MissionDirectory {
            get {
                return ((string)(this["MissionDirectory"]));
            }
            set {
                this["MissionDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedMission {
            get {
                return ((string)(this["SelectedMission"]));
            }
            set {
                this["SelectedMission"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("256000000")]
        public long SerialMappedFileCapacity {
            get {
                return ((long)(this["SerialMappedFileCapacity"]));
            }
            set {
                this["SerialMappedFileCapacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public uint SerialReceiveTimeout {
            get {
                return ((uint)(this["SerialReceiveTimeout"]));
            }
            set {
                this["SerialReceiveTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("512")]
        public uint SerialReceiveInputBufferSize {
            get {
                return ((uint)(this["SerialReceiveInputBufferSize"]));
            }
            set {
                this["SerialReceiveInputBufferSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public byte HeadsUpDisplayZoom {
            get {
                return ((byte)(this["HeadsUpDisplayZoom"]));
            }
            set {
                this["HeadsUpDisplayZoom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point HeadsUpDisplayLocation {
            get {
                return ((global::System.Drawing.Point)(this["HeadsUpDisplayLocation"]));
            }
            set {
                this["HeadsUpDisplayLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double YawOffset {
            get {
                return ((double)(this["YawOffset"]));
            }
            set {
                this["YawOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public byte TopFinOffset {
            get {
                return ((byte)(this["TopFinOffset"]));
            }
            set {
                this["TopFinOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public byte RightFinOffset {
            get {
                return ((byte)(this["RightFinOffset"]));
            }
            set {
                this["RightFinOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public byte BottomFinOffset {
            get {
                return ((byte)(this["BottomFinOffset"]));
            }
            set {
                this["BottomFinOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public byte LeftFinOffset {
            get {
                return ((byte)(this["LeftFinOffset"]));
            }
            set {
                this["LeftFinOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64")]
        public byte FinRange {
            get {
                return ((byte)(this["FinRange"]));
            }
            set {
                this["FinRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("155")]
        public byte illumination {
            get {
                return ((byte)(this["illumination"]));
            }
            set {
                this["illumination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double PitchOffset {
            get {
                return ((double)(this["PitchOffset"]));
            }
            set {
                this["PitchOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int MessageHistoryLength {
            get {
                return ((int)(this["MessageHistoryLength"]));
            }
            set {
                this["MessageHistoryLength"] = value;
            }
        }
    }
}
