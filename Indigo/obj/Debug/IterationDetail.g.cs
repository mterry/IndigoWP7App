﻿#pragma checksum "C:\Users\mat\Projects\Indigo\Indigo\IterationDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60C748FF5020B5FAC4E123FEF28C21F9"
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
    
    
    public partial class IterationDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage IterationDetailPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot IterationDetailPivot;
        
        internal Microsoft.Phone.Controls.PivotItem IterationDetailPivotItem;
        
        internal Microsoft.Phone.Controls.PivotItem TaskListPivotItem;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Indigo;component/IterationDetail.xaml", System.UriKind.Relative));
            this.IterationDetailPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("IterationDetailPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.IterationDetailPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("IterationDetailPivot")));
            this.IterationDetailPivotItem = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("IterationDetailPivotItem")));
            this.TaskListPivotItem = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("TaskListPivotItem")));
        }
    }
}

