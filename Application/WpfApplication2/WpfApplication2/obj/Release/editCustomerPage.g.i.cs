﻿#pragma checksum "..\..\editCustomerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39E87CB28488E2FF6BE0C0BD8EF903EE"
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
    /// editCustomerPage
    /// </summary>
    public partial class editCustomerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox storeNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ownerTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mobileTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\editCustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editProductButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\editCustomerPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/editcustomerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\editCustomerPage.xaml"
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
            
            #line 9 "..\..\editCustomerPage.xaml"
            ((WpfApplication2.editCustomerPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.storeNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\editCustomerPage.xaml"
            this.storeNameComboBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CharValidationTextBox);
            
            #line default
            #line hidden
            
            #line 44 "..\..\editCustomerPage.xaml"
            this.storeNameComboBox.LostFocus += new System.Windows.RoutedEventHandler(this.storeNameComboBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ownerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\editCustomerPage.xaml"
            this.ownerTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CharValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mobileTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\editCustomerPage.xaml"
            this.mobileTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.emailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.editProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\editCustomerPage.xaml"
            this.editProductButton.Click += new System.Windows.RoutedEventHandler(this.editProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.errorMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
