using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var rootCheat = Cheat.Create("GTA SA Andreas Cheats");
            CheatDictionary = new Dictionary<string, Cheat> {{rootCheat.UID, rootCheat}};

            AddExamples();

            AddCheatCommand = new DelegateCommand<Cheat>(OnAddCheat);
            EditCheatCommand = new DelegateCommand<Cheat>(OnEditCheat);
        }

        #endregion

        #region Methods

        private void OnAddCheat(Cheat cheat)
        {
            CheatDictionary.Add(cheat.UID, cheat);
        }

        private void OnEditCheat(Cheat cheat)
        {
            var target = CheatDictionary[cheat.UID];
            target.Cheats = cheat.Cheats;
            target.Code = cheat.Code;
            target.Info = cheat.Info;
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

        public Dictionary<string, Cheat> CheatDictionary { get; set; }
        public ICommand AddCheatCommand { get; set; }
        public ICommand EditCheatCommand { get; set; }
        public ObservableCollection<Cheat> Cheats => new ObservableCollection<Cheat>(CheatDictionary.Values);

        #endregion
    }
}