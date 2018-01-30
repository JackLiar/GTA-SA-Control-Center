using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Prism.Mvvm;

namespace ControlCenter.Cheats.Models
{
    public class Cheat : BindableBase
    {
        #region Constructor

        private Cheat(string code, bool isFolder = false)
        {
            Code = code;
            if (isFolder)
            {
                Info = $"New Folder: {DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()} (please edit this description)";
                _cheats = new ObservableCollection<string>();
                _cheats.CollectionChanged += OnCollectionChanged;
            }
            else
            {
                Info = $"New Cheat: {Code} (please edit this description)";
            }
            UID = Guid.NewGuid().ToString();
        }

        #endregion

        #region Fields & Properties


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
        private string _code = "";

        public string Info { get; set; }
        public string UID { get; }
        public string FatherUID { get; set; }

        public ObservableCollection<string> Cheats
        {
            get => _cheats;
            set => SetProperty(ref _cheats, value);
        }

        private ObservableCollection<string> _cheats;
        public bool IsFolder => _cheats != null;

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