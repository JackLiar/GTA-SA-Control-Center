using System;
using System.Windows.Input;
using ControlCenter.Infrastructure;
using Microsoft.VisualBasic;
using Prism.Commands;
using Prism.Mvvm;

namespace ControlCenter.VehicleAndGameData.ViewModels
{
    public class GameDataViewModel : BindableBase
    {
        #region Constructor

        public GameDataViewModel()
        {
            ResyncToGameCommand = new DelegateCommand(OnResyncToGame);
            SetMoneyCommand = new DelegateCommand(OnSetMoney);
            ClearCheatsCommand = new DelegateCommand(OnClearCheats);
            CheckStatusChangeCommand = new DelegateCommand(OnCheckStatusChange);
        }

        #endregion

        private void OnResyncToGame()
        {
            throw new NotImplementedException();
        }

        private void OnSetMoney()
        {
            if (Global.IsHasHandle && Global.IsHasPlayer)
            {
                var input = Interaction.InputBox("Enter new Money value", "Enter a value to set Money", 1.ToString());
                if (!string.IsNullOrEmpty(input) && long.TryParse(input, out var value))
                {
                    throw new NotImplementedException();
                }
            }
        }

        private void OnClearCheats()
        {
            throw new NotImplementedException();
        }

        private void OnCheckStatusChange()
        {
            Interaction.InputBox("test", "test", "1");
        }

        #region Fields & Properties

        public ICommand ResyncToGameCommand { get; set; }
        public ICommand SetMoneyCommand { get; set; }
        public ICommand ClearCheatsCommand { get; set; }
        public ICommand CheckStatusChangeCommand { get; set; }

        #endregion
    }
}