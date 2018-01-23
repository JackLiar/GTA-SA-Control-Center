using ControlCenter.Infrastructure;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.VisualBasic.CompilerServices;
using Prism.Commands;
using Prism.Mvvm;

namespace ControlCenter.VehicleAndGameData.ViewModels
{
    public class GameDataViewModel : BindableBase
    {
        #region Fields & Properties

        public ICommand ResyncToGameCommand { get; set; }
        public ICommand SetMoneyCommand { get; set; }
        public ICommand ClearCheatsCommand { get; set; }

        #endregion

        #region Constructor

        public GameDataViewModel()
        {
            ResyncToGameCommand = new DelegateCommand(OnResyncToGame);
            SetMoneyCommand = new DelegateCommand(OnSetMoney);
            ClearCheatsCommand = new DelegateCommand(OnClearCheats);
        }

        #endregion

        private void OnResyncToGame()
        {
            throw new NotImplementedException();
        }

        private void OnSetMoney()
        {
            if (Global.isHasHandle && Global.isHasPlayer)
            {
                var input = Interaction.InputBox("Enter new Money value", "Enter a value to set Money", 1.ToString());
                if (!string.IsNullOrEmpty(input) && long.TryParse(input, out long value))
                {
                    throw new NotImplementedException();
                }
            }
        }

        private void OnClearCheats()
        {
            throw new NotImplementedException();
        }
    }
}
