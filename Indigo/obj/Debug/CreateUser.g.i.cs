﻿#pragma checksum "C:\Users\mat\Projects\Indigo\Indigo\CreateUser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D38B7C39A2653826A1A91F2010278B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Indigo {
    
    
    public partial class CreateUser : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage CreateUserPage;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton SubmitAppBarIconButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton CancelAppBarIconButton;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock UsernameLabel;
        
        internal System.Windows.Controls.TextBox UsernameTextBox;
        
        internal System.Windows.Controls.TextBlock PasswordLabel;
        
        internal System.Windows.Controls.PasswordBox PasswordPBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Indigo;component/CreateUser.xaml", System.UriKind.Relative));
            this.CreateUserPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("CreateUserPage")));
            this.SubmitAppBarIconButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("SubmitAppBarIconButton")));
            this.CancelAppBarIconButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("CancelAppBarIconButton")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.UsernameLabel = ((System.Windows.Controls.TextBlock)(this.FindName("UsernameLabel")));
            this.UsernameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("UsernameTextBox")));
            this.PasswordLabel = ((System.Windows.Controls.TextBlock)(this.FindName("PasswordLabel")));
            this.PasswordPBox = ((System.Windows.Controls.PasswordBox)(this.FindName("PasswordPBox")));
        }
    }
}

