﻿#pragma checksum "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206A805921F745281D0AEA46A3C016882D9D751F"
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
        
        
        #line 77 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nameFilm;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker _movieTime;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox room;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _desPrice;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
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
            this.nameFilm = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this._movieTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 4:
            this.room = ((System.Windows.Controls.ComboBox)(target));
            
            #line 151 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
            this.room.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.room_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._desPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 248 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\AddShowtimeWindow.xaml"
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

