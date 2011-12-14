﻿using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Indigo.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Properties
        
        string DisplayName;

        #endregion

        protected virtual void OnNotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public bool IsDesignTime
        {
            get
            {
                return (Application.Current == null) || (Application.Current.GetType() == typeof(Application));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
