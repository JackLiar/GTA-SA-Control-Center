using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace ControlCenter.ViewModels
{
    public class PickColorWindowViewModel : BindableBase
    {
        #region Fields & Properties

        /// <summary> Command to confirm the selected color </summary>
        public ICommand ColorPickOkCommand { get; }
        
        /// <summary> Command to cancel selecting color and close the color pick window </summary>
        public ICommand ColorPickCancelCommand { get; }

        /// <summary> Command to select color </summary>
        public ICommand ColorsClickCommand { get; }

        /// <summary> Command to select color </summary>
        public ICommand ColorsDoubleClickCommand { get; }
        
        /// <summary> The color player selected </summary>
        public int SelectedColor { get; set; }
        
        private IEventAggregator _eventAggregator;

        #endregion

        #region Constructor

        public PickColorWindowViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            ColorPickOkCommand = new DelegateCommand<Window>(OnColorPickOkCommand);
            ColorPickCancelCommand = new DelegateCommand<Window>(OnColorPickCancelCommand);
            ColorsClickCommand = new DelegateCommand<Label>(OnColorsClickCommand);
            //ColorsDoubleClickCommand = new DelegateCommand(OnColorsDoubleClickCommand);
        }

        #endregion

        #region Methods

        private void OnColorPickOkCommand(Window window)
        {
            // TODO: Raise color selected event by eventAggregator
            window.Close();
        }

        /// <summary> Cancel selecting color and close the color pick window </summary>
        private void OnColorPickCancelCommand(Window window)
        {
            window.Close();
        }

        private void OnColorsClickCommand(Label label)
        {
            SelectedColor = label.TabIndex;
        }

        private void OnColorsDoubleClickCommand(Label label)
        {
            SelectedColor = label.TabIndex;
        }

        #endregion
    }
}
