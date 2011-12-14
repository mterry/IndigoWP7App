using System;
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
    public partial class CreateUser : PhoneApplicationPage
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
        	NavigationService.GoBack();
        }
    }
}
