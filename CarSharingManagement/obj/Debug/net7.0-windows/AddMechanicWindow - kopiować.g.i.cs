﻿#pragma checksum "..\..\..\AddMechanicWindow - kopiować.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBC83FCF064BFCBD4FD8A05D7D385F6611291712"
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
    /// AddMechanicWindow
    /// </summary>
    public partial class AddMechanicWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddMechanicWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AddMechanicLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\AddMechanicWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddMechanicNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\AddMechanicWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddMechanicSurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AddMechanicWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMechanicDeclineButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddMechanicWindow - kopiować.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMechanicAddButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.14.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarSharingManagement;V1.0.0.0;component/addmechanicwindow%20-%20kopiowa%c4%87.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddMechanicWindow - kopiować.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.14.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddMechanicLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.AddMechanicNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\AddMechanicWindow - kopiować.xaml"
            this.AddMechanicNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AddMechanicNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddMechanicSurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\AddMechanicWindow - kopiować.xaml"
            this.AddMechanicSurnameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AddMechanicSurnameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddMechanicDeclineButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\AddMechanicWindow - kopiować.xaml"
            this.AddMechanicDeclineButton.Click += new System.Windows.RoutedEventHandler(this.AddMechanicDeclineButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddMechanicAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\AddMechanicWindow - kopiować.xaml"
            this.AddMechanicAddButton.Click += new System.Windows.RoutedEventHandler(this.AddMechanicAddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

