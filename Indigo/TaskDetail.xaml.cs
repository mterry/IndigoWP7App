﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Indigo
{
    public partial class TaskDetail : PhoneApplicationPage
    {
        public TaskDetail()
        {
            InitializeComponent();
        }

        private void EditTaskAppBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/EditTask.xaml", UriKind.Relative));
        }
    }
}
