﻿#pragma checksum "C:\Users\mat\Projects\Indigo\Indigo\TaskDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B47F3E0916B4E87B020F46505BF4C706"
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
    
    
    public partial class TaskDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage TaskDetailPage;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton EditTaskAppBarIconButton;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot TaskDetailPivot;
        
        internal Microsoft.Phone.Controls.PivotItem TaskDetailPivotItem;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock TaskTitle;
        
        internal System.Windows.Controls.TextBlock TaskNumber;
        
        internal System.Windows.Controls.TextBlock TaskPointsLabel;
        
        internal System.Windows.Controls.TextBlock TaskPointsField;
        
        internal System.Windows.Controls.TextBlock TaskAssignedToLabel;
        
        internal System.Windows.Controls.TextBlock TaskAssignedToField;
        
        internal System.Windows.Controls.TextBlock TaskClosedLabel;
        
        internal System.Windows.Controls.TextBlock TaskClosedField;
        
        internal System.Windows.Controls.TextBlock TaskDescriptionLabel;
        
        internal System.Windows.Controls.TextBlock TaskDescriptionField;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Indigo;component/TaskDetail.xaml", System.UriKind.Relative));
            this.TaskDetailPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("TaskDetailPage")));
            this.EditTaskAppBarIconButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("EditTaskAppBarIconButton")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TaskDetailPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("TaskDetailPivot")));
            this.TaskDetailPivotItem = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("TaskDetailPivotItem")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TaskTitle = ((System.Windows.Controls.TextBlock)(this.FindName("TaskTitle")));
            this.TaskNumber = ((System.Windows.Controls.TextBlock)(this.FindName("TaskNumber")));
            this.TaskPointsLabel = ((System.Windows.Controls.TextBlock)(this.FindName("TaskPointsLabel")));
            this.TaskPointsField = ((System.Windows.Controls.TextBlock)(this.FindName("TaskPointsField")));
            this.TaskAssignedToLabel = ((System.Windows.Controls.TextBlock)(this.FindName("TaskAssignedToLabel")));
            this.TaskAssignedToField = ((System.Windows.Controls.TextBlock)(this.FindName("TaskAssignedToField")));
            this.TaskClosedLabel = ((System.Windows.Controls.TextBlock)(this.FindName("TaskClosedLabel")));
            this.TaskClosedField = ((System.Windows.Controls.TextBlock)(this.FindName("TaskClosedField")));
            this.TaskDescriptionLabel = ((System.Windows.Controls.TextBlock)(this.FindName("TaskDescriptionLabel")));
            this.TaskDescriptionField = ((System.Windows.Controls.TextBlock)(this.FindName("TaskDescriptionField")));
        }
    }
}

