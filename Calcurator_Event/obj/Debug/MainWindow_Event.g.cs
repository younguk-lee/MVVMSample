﻿#pragma checksum "..\..\MainWindow_Event.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63D9D96A6E5EC31E89A95B5BC55F508A3B161269EB3A3117A18696105716497E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Calcurator_Event;
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


namespace Calcurator_Event {
    
    
    /// <summary>
    /// MainWindow_Event
    /// </summary>
    public partial class MainWindow_Event : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow_Event.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTitle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow_Event.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_plus;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow_Event.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_minus;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow_Event.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCount;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow_Event.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_subwindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Calcurator_Event;component/mainwindow_event.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow_Event.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.button_plus = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MainWindow_Event.xaml"
            this.button_plus.Click += new System.Windows.RoutedEventHandler(this.button_plus_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_minus = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow_Event.xaml"
            this.button_minus.Click += new System.Windows.RoutedEventHandler(this.button_minus_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblCount = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.button_subwindow = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainWindow_Event.xaml"
            this.button_subwindow.Click += new System.Windows.RoutedEventHandler(this.button_subwindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
