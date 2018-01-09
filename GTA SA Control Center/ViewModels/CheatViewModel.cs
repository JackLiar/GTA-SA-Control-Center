using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace ControlCenter.ViewModels
{
    public class CheatViewModel : BindableBase
    {
        #region Fields & Properties

        public ICommand ChangeLockStateCommand { get; }
        public string ButtonContent { get; set; }
        public string ButtonToolTip { get; set; }

        #endregion

        #region Constructor

        public CheatViewModel()
        {
            ChangeLockStateCommand = new DelegateCommand(OnChangeLockStateCommand);
        }

        #endregion

        #region Methods

        private void OnChangeLockStateCommand()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
