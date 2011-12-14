using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Indigo.Models;

namespace Indigo.ViewModels
{
    public class ProjectListViewModel : ViewModelBase
    {
        public ProjectListViewModel()
        {
            this.Projects = new ObservableCollection<Project>();
        }

        #region Properties

        public ObservableCollection<Project> Projects
        {
            get;
            private set;
        }

        string DisplayName = "project list";

        private uint _Id;
        public uint Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                OnNotifyPropertyChanged("Id");
            }
        }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnNotifyPropertyChanged("Name");
            }
        }
        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                OnNotifyPropertyChanged("Description");
            }
        }

        #endregion
    }
}
