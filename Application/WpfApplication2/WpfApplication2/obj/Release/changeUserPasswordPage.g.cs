﻿#pragma checksum "..\..\changeUserPasswordPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AFEA26DCF88D09B1EC3CFB1FF040F55F"
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
    /// changeUserPasswordPage
    /// </summary>
    public partial class changeUserPasswordPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userNameLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox oldPasswTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox rePasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveNewButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\changeUserPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/changeuserpasswordpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\changeUserPasswordPage.xaml"
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
            this.userNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.userNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.oldPasswTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.passwordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.rePasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.saveNewButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\changeUserPasswordPage.xaml"
            this.saveNewButton.Click += new System.Windows.RoutedEventHandler(this.saveNewCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\changeUserPasswordPage.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

