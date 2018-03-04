using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using Prism.Mvvm;

namespace ControlCenter.Locations.Models
{
    public class Location : BindableBase
    {
        #region Constructor

        public Location(Coordinate coordinate, bool isFolder = false)
        {
            if (isFolder)
            {
                Info = $"New Folder: {DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()} (please edit this description)";
                _locations = new ObservableCollection<string>();
                _locations.CollectionChanged += OnCollectionChanged;
            }
            else
            {
                Info = "New Location (please edit this description)";
                _coordinate = coordinate;
            }
            UID = Guid.NewGuid().ToString();
        }

        #endregion

        #region Fields & Properties

        public Coordinate Coordinate
        {
            get => IsFolder ? null : _coordinate;
            set
            {
                if (IsFolder)
                {
                    return;
                }
                _coordinate = value;
            }
        }
        private Coordinate _coordinate;

        public string Info { get; set; }
        public string UID { get; }
        public string FatherUID { get; set; }

        public string X => _coordinate?.X.ToString(CultureInfo.InvariantCulture) ?? "";
        public string Y => _coordinate?.Y.ToString(CultureInfo.InvariantCulture) ?? "";
        public string Z => _coordinate?.Z.ToString(CultureInfo.InvariantCulture) ?? "";
        public string Angle => _coordinate?.Angle.ToString(CultureInfo.InvariantCulture) ?? "";

        public ObservableCollection<string> Locations
        {
            get => _locations;
            set => SetProperty(ref _locations, value);
        }
        private ObservableCollection<string> _locations;
        public bool IsFolder => _locations != null;

        #endregion

        #region Methods

        public static Location Create(Coordinate coordinate, bool isFolder = false)
        {
            return new Location(coordinate, isFolder);
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged("Locations");
        }

        #endregion
    }
}
