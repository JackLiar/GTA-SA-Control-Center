using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ControlCenter.Locations.Converters;
using ControlCenter.Locations.Models;
using Prism.Commands;

namespace ControlCenter.Locations.ViewModels
{
    public class MainViewModel
    {
        #region Constructor

        public MainViewModel()
        {
#if DEBUG
            var rootCheat = Location.Create(null, true);
            LocationDictionary = new Dictionary<string, Location> {{rootCheat.UID, rootCheat}};
            Locations = new ObservableCollection<Location> {rootCheat};
#endif

            AddLocationCommand = new DelegateCommand<Tuple<string, string>>(OnAddLocation);
            AddLocationFolderCommand = new DelegateCommand<Tuple<string, string>>(OnAddLocationFolder);
            DeleteLocationCommand = new DelegateCommand<string>(OnDeleteLocation);
            EditLocationCommand = new DelegateCommand<Tuple<string, string>>(OnEditLocation);
        }

        #endregion

        #region Fields & Properties

        public ICommand AddLocationCommand { get; }
        public ICommand AddLocationFolderCommand { get; }
        public ICommand DeleteLocationCommand { get; }
        public ICommand EditLocationCommand { get; }

        public Dictionary<string, Location> LocationDictionary { get; set; }
        public ObservableCollection<Location> Locations { get; set; }

        #endregion

        #region Methods

        private void OnAddLocation(Tuple<string, string> tuple)
        {
            if (tuple == null)
            {
                MessageBox.Show("Please select a folder to add this location!", "GTA SA Control Center");
                return;
            }
            var target = LocationDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                MessageBox.Show("Please select a folder to add this location!", "GTA SA Control Center");
                return;
            }
            var cheat = Location.Create(StringToCoordinateConverter.Convert(tuple.Item2));
            cheat.FatherUID = target.UID;

            LocationDictionary.Add(cheat.UID, cheat);

            if (target.Locations == null)
            {
                target.Locations = new ObservableCollection<string>();
            }
            target.Locations.Add(cheat.UID);
        }

        private void OnAddLocationFolder(Tuple<string, string> tuple)
        {
            if (tuple == null)
            {
                MessageBox.Show("Please select a folder to add this folder!", "GTA SA Control Center");
                return;
            }
            var target = LocationDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                MessageBox.Show("Please select a folder to add this folder!", "GTA SA Control Center");
                return;
            }
            var folder = Location.Create(null, true);
            folder.FatherUID = target.UID;

            LocationDictionary.Add(folder.UID, folder);

            if (target.Locations == null)
            {
                target.Locations = new ObservableCollection<string>();
            }
            target.Locations.Add(folder.UID);
        }

        private void OnDeleteLocation(string uid)
        {
            if (LocationDictionary[uid].FatherUID != null)
            {
                LocationDictionary[LocationDictionary[uid].FatherUID].Locations.Remove(uid);
            }
            else
            {
                Locations.Remove(LocationDictionary[uid]);
                LocationDictionary.Remove(uid);
            }
        }

        private void OnEditLocation(Tuple<string, string> tuple)
        {
            var target = LocationDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                target.Coordinate = StringToCoordinateConverter.Convert(tuple.Item2);
            }
        }

        #endregion
    }
}