using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.VisualBasic;
using Prism.Commands;
using Prism.Mvvm;

namespace ControlCenter.VehicleAndGameData.ViewModels
{
    public class CurrentCarViewModel : BindableBase
    {
        #region Fields & Properties

        #region check box bindings

        #region prevent car damages

        public bool IsPreventDamageEnabled { get; set; } = true;
        public bool IsExplosionEnabled { get; set; } = true;
        public bool IsCollisionEnabled { get; set; } = true;
        public bool IsBulletEnabled { get; set; } = true;
        public bool IsFireEnabled { get; set; } = true;

        #endregion

        public bool IsEngineHealthEnabled { get; set; } = true;
        public bool IsCarWeightEnabled { get; set; } = true;
        public bool IsFlyAssistanceEnabled { get; set; } = false;
        public bool IsCarDoorEnabled { get; set; } = true;
        public bool IsCarColorEnabled { get; set; } = true;
        public bool IsWheelDamageEnabled { get; set; } = true;
        public bool IsAutoStopAlarmEnabled { get; set; } = true;
        public bool IsAutoRestartCarEnabled { get; set; } = true;
        public bool IsControlRcVehicleEnabled { get; set; } = true;
        public bool IsSetLicensePlateEnabled { get; set; } = false;

        #endregion

        public ICommand ChangeCarSpecCommand { get; set; }
        public ICommand CheckStatusChangeCommand { get; set; }

        #endregion

        #region Constructor

        public CurrentCarViewModel()
        {
            CheckStatusChangeCommand = new DelegateCommand(OnCheckStatusChange);
        }

        #endregion

        #region Methods

        private void OnChangeCarSpec()
        {

        }

        private void OnCheckStatusChange()
        {
            Interaction.InputBox("test", "test", "1");
        }

        #endregion
    }
}
