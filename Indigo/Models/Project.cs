using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Indigo.Models
{
	public class Project : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties

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
                OnPropertyChanged("Id");
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
                OnPropertyChanged("Name");
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
                OnPropertyChanged("Description");
            }
        }
		private uint _Velocity;
        public uint Velocity
        {
            get
            {
                return _Velocity;
            }
            set
            {
                _Velocity = value;
                OnPropertyChanged("Velocity");
            }
        }
        private uint _TaskPointTimescale;
        public uint TaskPointTimescale
        {
            get
            {
                return _TaskPointTimescale;
            }
            set
            {
                _TaskPointTimescale = value;
                OnPropertyChanged("TaskPointTimescale");
            }
        }
		private User _Owner;
        public User Owner
        {
            get
            {
                return _Owner;
            }
            set
            {
                _Owner = value;
                OnPropertyChanged("Owner");
            }
        }
		public ObservableCollection<User> Collaborators;

        #endregion

        public Project()
		{
			// Insert code required on object creation below this point.
        }

        #region Members

        protected virtual void OnPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }

        #endregion
    }
}