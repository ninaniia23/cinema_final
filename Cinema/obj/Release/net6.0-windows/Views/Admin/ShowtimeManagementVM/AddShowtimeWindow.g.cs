﻿#pragma checksum "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DAABBDF966F08C2398FCB04511A588C415811DB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cinema.Views.Admin.ShowtimeManagementVM;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Cinema.Views.Admin.ShowtimeManagementVM {
    
    
    /// <summary>
    /// AddShowtimeWindow
    /// </summary>
    public partial class AddShowtimeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _movieName;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker _movieDate;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker _movieTime;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _movieRoom;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _moviePrice;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _desPrice;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar prg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cinema;component/views/admin/showtimemanagementvm/addshowtimewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._movieName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this._movieDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this._movieTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 4:
            this._movieRoom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this._moviePrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._desPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 250 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.prg = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

