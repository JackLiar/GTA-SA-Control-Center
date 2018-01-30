using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ControlCenter.Infrastructure;
using ControlCenter.Locations.Models;

namespace ControlCenter.Locations.ViewModels
{
    public class ControlViewModel
    {
        #region Constructor

        public ControlViewModel()
        {
            var rootCheat = Location.Create(new Coordinate(0,0,0,0));
            LocationDictionary = new Dictionary<string, Location> { { rootCheat.UID, rootCheat } };
            Locations = new ObservableCollection<Location> { rootCheat };
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

        //private void OnAddCheat(Tuple<string, string> tuple)
        //{
        //    if (tuple == null)
        //    {
        //        MessageBox.Show("Please select a folder to add this cheat!", "GTA SA Control Center");
        //        return;
        //    }
        //    var target = LocationDictionary[tuple.Item1];
        //    if (!target.IsFolder)
        //    {
        //        MessageBox.Show("Please select a folder to add this cheat!", "GTA SA Control Center");
        //        return;
        //    }
        //    var cheat = Location.Create(tuple.Item2);
        //    cheat.FatherUID = target.UID;

        //    LocationDictionary.Add(cheat.UID, cheat);

        //    if (target.Locations == null)
        //    {
        //        target.Locations = new ObservableCollection<string>();
        //    }
        //    target.Locations.Add(cheat.UID);
        //}

        


        #endregion
    }
}
