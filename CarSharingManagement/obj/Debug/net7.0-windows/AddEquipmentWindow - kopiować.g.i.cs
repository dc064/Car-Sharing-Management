﻿#pragma checksum "..\..\..\AddEquipmentWindow - kopiować.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6A2BE375F67592705B9F988B27D15E7A3DEA27C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using CarSharingManagement;
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


namespace CarSharingManagement {
    
    
    /// <summary>
    /// AddEquipmentWindow
    /// </summary>
    public partial class AddEquipmentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EquipmentDescriptionBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeclineButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HasAirConditioner;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SeatsNumberSlider;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AddEquipmentWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SeatNumberTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarSharingManagement;V1.0.0.0;component/addequipmentwindow%20-%20kopiowa%c4%87.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EquipmentDescriptionBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            this.EquipmentDescriptionBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EquipmentDescriptionBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeclineButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            this.DeclineButton.Click += new System.Windows.RoutedEventHandler(this.DeclineButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ApplyButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            this.ApplyButton.Click += new System.Windows.RoutedEventHandler(this.ApplyButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HasAirConditioner = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            this.HasAirConditioner.Checked += new System.Windows.RoutedEventHandler(this.HasAirConditioner_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SeatsNumberSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\..\AddEquipmentWindow - kopiować.xaml"
            this.SeatsNumberSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SeatsNumberSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SeatNumberTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

