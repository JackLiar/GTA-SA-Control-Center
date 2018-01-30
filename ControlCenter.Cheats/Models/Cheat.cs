using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Prism.Mvvm;

namespace ControlCenter.Cheats.Models
{
    public class Cheat : BindableBase
    {

        #region Fields & Properties

        private string _code = "";

        public string Code
        {
            get => IsFolder ? "" : _code;
            set
            {
                if (IsFolder)
                {
                    return;
                }
                _code = value;
            }
        }
        public string Info { get; set; }
        public string UID { get; }
        public string FatherUID { get; set; }

        public ObservableCollection<string> Cheats
        {
            get => cheats;
            set
            {
                if (cheats != null)
                {
                    SetProperty(ref cheats, value);
                    return;
                }
                SetProperty(ref cheats, value);
                cheats.CollectionChanged += OnCollectionChanged;
            }
        }
        private ObservableCollection<string> cheats;
        public bool IsFolder => Cheats != null;

        #endregion

        #region Constructor

        private Cheat(string code, bool isFolder = false)
        {
            Code = code;
            Info = isFolder ?
                $"New Folder: {DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()} (please edit this description)" :
                $"New Cheat: {Code} (please edit this description)";
            UID = Guid.NewGuid().ToString();
        }

        #endregion

        #region Methods

        public static Cheat Create(string code, bool isFolder = false)
        {
            return new Cheat(code, isFolder);
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged("Cheats");
        }

        #endregion
    }
}
