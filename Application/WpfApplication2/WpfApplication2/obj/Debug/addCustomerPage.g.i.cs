﻿#pragma checksum "..\..\addCustomerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E6B88BEC1C70838F6CBA68F038F4760"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Forms.Integration;
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
using WpfApplication2;


namespace WpfApplication2 {
    
    
    /// <summary>
    /// addCustomerPage
    /// </summary>
    public partial class addCustomerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox storeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ownerTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mobileTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveNewCustomerButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\addCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errorMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/addcustomerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addCustomerPage.xaml"
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
            this.storeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\addCustomerPage.xaml"
            this.storeNameTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CharValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ownerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\addCustomerPage.xaml"
            this.ownerTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CharValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mobileTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\addCustomerPage.xaml"
            this.mobileTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.emailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.saveNewCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\addCustomerPage.xaml"
            this.saveNewCustomerButton.Click += new System.Windows.RoutedEventHandler(this.saveNewCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.errorMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

