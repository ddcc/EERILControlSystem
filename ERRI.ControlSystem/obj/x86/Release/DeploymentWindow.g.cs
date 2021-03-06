﻿#pragma checksum "..\..\..\DeploymentWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DD6796E7F8C8B3A05C5A35E129A40D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EERIL.ControlSystem {
    
    
    /// <summary>
    /// DeploymentWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class DeploymentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel controlPanel;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label missionLabel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel addMissionPanel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addMissionTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addMissionButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox missionList;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dateTimeLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dateTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label notesLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox notesRichTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel deploymentButtonPanel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deployButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\DeploymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EERIL.ControlSystem;component/deploymentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DeploymentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\DeploymentWindow.xaml"
            ((EERIL.ControlSystem.DeploymentWindow)(target)).Closed += new System.EventHandler(this.WindowClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.controlPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.missionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.addMissionPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.addMissionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.addMissionButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\DeploymentWindow.xaml"
            this.addMissionButton.Click += new System.Windows.RoutedEventHandler(this.addMissionButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.missionList = ((System.Windows.Controls.ListBox)(target));
            
            #line 14 "..\..\..\DeploymentWindow.xaml"
            this.missionList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MissionListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dateTimeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.dateTimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.notesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.notesRichTextBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 12:
            this.deploymentButtonPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 13:
            this.deployButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\DeploymentWindow.xaml"
            this.deployButton.Click += new System.Windows.RoutedEventHandler(this.deployButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\DeploymentWindow.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

