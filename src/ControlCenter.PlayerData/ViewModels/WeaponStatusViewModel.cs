using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCenter.PlayerData.ViewModels
{
    public class WeaponStatusViewModel
    {
        #region Constructor

        public WeaponStatusViewModel()
        {
            
        }

        #endregion

        #region Fields & Properties

        public IList<string> MeleeWeapons { get; }
        public IList<string> Handguns { get; }
        public IList<string> Shotguns { get; }
        public IList<string> SubmachineGuns { get; }
        public IList<string> AssaultRifles { get; }
        public IList<string> SniperRifles { get; }
        public IList<string> HeavyWeapons { get; }
        public IList<string> ThrownWeapons { get; }
        public IList<string> ConsumableItems { get; }
        public IList<string> Gifts { get; }
        public IList<string> Specials { get; }

        #endregion

        #region Methods



        #endregion
    }
}
