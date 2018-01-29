using System;
using System.Collections.Generic;

namespace ControlCenter.Cheats.Models
{
    public class Cheat
    {

        #region Fields & Properties

        public string Code { get; set; }
        public string Info { get; set; }
        public string UID { get; set; }
        public IList<string> Cheats { get; set; }
        public bool IsFolder => Cheats != null;

        #endregion

        #region Constructor

        private Cheat(string code)
        {
            Code = code;
            Info = $"New Cheat: {Code} (please edit this description)";
            UID = Guid.NewGuid().ToString();
        }

        #endregion

        #region Methods

        public static Cheat Create(string code)
        {
            return new Cheat(code);
        }

        #endregion
    }
}
