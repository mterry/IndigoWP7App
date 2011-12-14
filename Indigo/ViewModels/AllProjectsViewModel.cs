using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Indigo.Models;

namespace Indigo.ViewModels
{
    public class AllProjectsViewModel : ProjectListViewModel
    {
        #region Properties

        string DisplayName = "all projects";

        public ObservableCollection<Project> AllProjects
        {
            get;
            private set;
        }

        private string _Uri;
        public string Uri
        {
            get
            {
                return _Uri;
            }
            set
            {
                _Uri = value;
                OnNotifyPropertyChanged("Uri");
            }
        }

        #endregion

        public AllProjectsViewModel()
        {
        }

        public void Load()
        {
            if (this.Uri == null)
            {
                throw new Exception("Uri is not set.");
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(this._Uri));
            AllProjectsState allProjectsState = new AllProjectsState();
            allProjectsState.AsyncRequest = request;

            request.BeginGetResponse(new AsyncCallback(AsyncResponseCallback), allProjectsState);
        }

        public void AsyncResponseCallback(IAsyncResult asyncResult)
        {
            AllProjectsState allProjectsState = (AllProjectsState)asyncResult.AsyncState;
            HttpWebRequest request = (HttpWebRequest)allProjectsState.AsyncRequest;

            allProjectsState.AsyncResponse = (HttpWebResponse)request.EndGetResponse(asyncResult);

            Stream xmlStream = allProjectsState.AsyncResponse.GetResponseStream();

            XDocument loadedData = XDocument.Load(xmlStream);

            var data = from query in loadedData.Descendants("Project")
                       select new Project
                       {
                           Id = (uint)query.Element("id"),
                           Name = (string)query.Element("name"),
                           Description = ""
                       };

            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                AllProjects = new ObservableCollection<Project>(data);
            });
        }

        public class AllProjectsState
        {
            public HttpWebRequest AsyncRequest { get; set; }
            public HttpWebResponse AsyncResponse { get; set; }
        }
    }
}
