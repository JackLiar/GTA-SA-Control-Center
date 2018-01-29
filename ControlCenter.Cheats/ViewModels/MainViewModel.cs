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
            var rootCheat = Cheat.Create("GTA SA Cheats");
            CheatDictionary = new Dictionary<string, Cheat> {{rootCheat.UID, rootCheat}};
            Cheats = new ObservableCollection<Cheat> {rootCheat};

#if DEBUG
            AddExamples();
#endif

            AddCheatCommand = new DelegateCommand<Tuple<string, string>>(OnAddCheat);
            AddCheatFolderCommand = new DelegateCommand<Cheat>(OnAddCheatFolder);
            DeleteCheatCommand = new DelegateCommand(OnDeleteCheat);
            ReadFromConfigCommand = new DelegateCommand(OnReadFromConfig);
            SaveToConfigCommand = new DelegateCommand(OnSaveToConfig);
            EditCheatCommand = new DelegateCommand<Tuple<string, string>>(OnEditCheat);
        }

        #endregion

        #region Methods

        private void OnAddCheat(Tuple<string, string> tuple)
        {
            var target = CheatDictionary[tuple.Item1];
            if (!target.IsFolder)
            {
                MessageBox.Show("Please select a folder to add this cheat!", "GTA SA Control Center");
                return;
            }
            var cheat = Cheat.Create(tuple.Item2);

            CheatDictionary.Add(cheat.UID, cheat);

            if (target.Cheats == null)
            {
                target.Cheats = new List<string>();
            }
            target.Cheats.Add(cheat.UID);
        }

        private void OnAddCheatFolder(Cheat cheat)
        {
            CheatDictionary.Add(cheat.UID, cheat);
        }

        private void OnDeleteCheat()
        {
            throw new NotImplementedException();
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
                CheatDictionary.Add(cheat.UID, cheat);
                if (Cheats[0].Cheats == null)
                {
                    Cheats[0].Cheats = new List<string>();
                }
                Cheats[0].Cheats.Add(cheat.UID);
            }
        }

#endif

        #endregion

        #region Fields & Properties

        public ICommand AddCheatCommand { get; set; }
        public ICommand AddCheatFolderCommand { get; set; }
        public ICommand DeleteCheatCommand { get; set; }
        public ICommand ReadFromConfigCommand { get; set; }
        public ICommand SaveToConfigCommand { get; set; }
        public ICommand EditCheatCommand { get; set; }
        public Dictionary<string, Cheat> CheatDictionary { get; set; }
        public ObservableCollection<Cheat> Cheats { get; set; }

        #endregion
    }
}