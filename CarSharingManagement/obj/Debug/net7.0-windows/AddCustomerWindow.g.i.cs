﻿#pragma checksum "..\..\..\AddCustomerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43433E95918BA9C12DC8257320D5EACB173AC3F8"
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
    /// AddCustomerWindow
    /// </summary>
    public partial class AddCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeclineButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerSurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerEmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerNameLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerSurnameLabel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerEmailLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarSharingManagement;V1.0.0.0;component/addcustomerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddCustomerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DeclineButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\AddCustomerWindow.xaml"
            this.DeclineButton.Click += new System.Windows.RoutedEventHandler(this.DeclineButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ApplyButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\AddCustomerWindow.xaml"
            this.ApplyButton.Click += new System.Windows.RoutedEventHandler(this.ApplyButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CustomerNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\AddCustomerWindow.xaml"
            this.CustomerNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CustomerNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CustomerSurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\AddCustomerWindow.xaml"
            this.CustomerSurnameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CustomerSurnameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CustomerEmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\AddCustomerWindow.xaml"
            this.CustomerEmailTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CustomerEmailTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CustomerNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.CustomerSurnameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.CustomerEmailLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.CustomerLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

