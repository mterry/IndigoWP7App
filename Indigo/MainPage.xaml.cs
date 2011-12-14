using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using Indigo.ViewModels;

namespace Indigo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            AllProjectsViewModel allProjectsViewModel = new AllProjectsViewModel();
            DataContext = allProjectsViewModel;

            this.Loaded +=new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ProjectListItemViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ((AllProjectsViewModel)DataContext).Uri = "http://www.timepiecestudios.net/indigo/api/project/list/all";
            ((AllProjectsViewModel)DataContext).Load();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
			NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void CreateUser_Click(object sender, System.EventArgs e)
        {
			NavigationService.Navigate(new Uri("/CreateUser.xaml", UriKind.Relative));
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }
    }
}