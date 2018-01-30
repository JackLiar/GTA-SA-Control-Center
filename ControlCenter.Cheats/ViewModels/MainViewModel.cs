using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ControlCenter.Cheats.Models;
using Prism.Commands;

namespace ControlCenter.Cheats.ViewModels
{
    public class MainViewModel
    {
        #region Constructor

        public MainViewModel()
        {
#if DEBUG
            var rootCheat = Cheat.Create("GTA SA Cheats", true);
            CheatDictionary = new Dictionary<string, Cheat> {{rootCheat.UID, rootCheat}};
            Cheats = new ObservableCollection<Cheat> {rootCheat};
            AddExamples();
#endif
            AddCheatCommand = new DelegateCommand<Tuple<string, string>>(OnAddCheat);
            AddCheatFolderCommand = new DelegateCommand<Tuple<string, string>>(OnAddCheatFolder);
            DeleteCheatCommand = new DelegateCommand<string>(OnDeleteCheat);
            ReadFromConfigCommand = new DelegateCommand(OnReadFromConfig);
            SaveToConfigCommand = new DelegateCommand(OnSaveToConfig);
            EditCheatCommand = new DelegateCommand<Tuple<string, string>>(OnEditCheat);
        }

        #endregion

        #region Methods

        private void OnAddCheat(Tuple<string, string> tuple)
        {
            if (tuple == null)
            {
                MessageBox.Show("Please select a folder to add this cheat!", "GTA SA Control Center");
                return;
            }
            var target = CheatDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                MessageBox.Show("Please select a folder to add this cheat!", "GTA SA Control Center");
                return;
            }
            var cheat = Cheat.Create(tuple.Item2);
            cheat.FatherUID = target.UID;

            CheatDictionary.Add(cheat.UID, cheat);

            if (target.Cheats == null)
            {
                target.Cheats = new ObservableCollection<string>();
            }
            target.Cheats.Add(cheat.UID);
        }

        private void OnAddCheatFolder(Tuple<string, string> tuple)
        {
            if (tuple == null)
            {
                MessageBox.Show("Please select a folder to add this folder!", "GTA SA Control Center");
                return;
            }
            var target = CheatDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                MessageBox.Show("Please select a folder to add this folder!", "GTA SA Control Center");
                return;
            }
            var folder = Cheat.Create(tuple.Item2, true);
            folder.FatherUID = target.UID;

            CheatDictionary.Add(folder.UID, folder);

            if (target.Cheats == null)
            {
                target.Cheats = new ObservableCollection<string>();
            }
            target.Cheats.Add(folder.UID);
        }

        private void OnDeleteCheat(string uid)
        {
            if (CheatDictionary[uid].FatherUID != null)
            {
                CheatDictionary[CheatDictionary[uid].FatherUID].Cheats.Remove(uid);
            }
            else
            {
                Cheats.Remove(CheatDictionary[uid]);
                CheatDictionary.Remove(uid);
            }
        }

        private void OnEditCheat(Tuple<string, string> tuple)
        {
            var target = CheatDictionary[tuple.Item1];
            target.Code = tuple.Item2;
        }

        private void OnReadFromConfig()
        {
            throw new NotImplementedException();
        }

        private void OnSaveToConfig()
        {
            throw new NotImplementedException();
        }

#if DEBUG

        private void AddExamples()
        {
            for (var i = 0; i < 10; i++)
            {
                var cheat = Cheat.Create("Example" + i);
                cheat.FatherUID = Cheats[0].UID;
                CheatDictionary.Add(cheat.UID, cheat);
                Cheats[0].Cheats.Add(cheat.UID);
            }
        }

#endif

        #endregion

        #region Fields & Properties

        public ICommand AddCheatCommand { get; }
        public ICommand AddCheatFolderCommand { get; }
        public ICommand DeleteCheatCommand { get; }
        public ICommand ReadFromConfigCommand { get; }
        public ICommand SaveToConfigCommand { get; }
        public ICommand EditCheatCommand { get; }
        public Dictionary<string, Cheat> CheatDictionary { get; set; }
        public ObservableCollection<Cheat> Cheats { get; set; }

        #endregion
    }
}