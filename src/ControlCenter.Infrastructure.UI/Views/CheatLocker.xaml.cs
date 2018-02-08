using System.Windows;
using System.Windows.Controls;

namespace ControlCenter.Infrastructure.UI.Views
{
    /// <summary>
    ///     Interaction logic for CheatLocker.xaml
    /// </summary>
    public partial class CheatLocker : UserControl
    {
        public static readonly DependencyProperty IsLockedProperty = DependencyProperty.Register(
            "IsLocked", typeof(bool), typeof(CheatLocker), new PropertyMetadata(default(bool)));

        public static readonly DependencyProperty CheckBoxContentProperty = DependencyProperty.Register(
            "CheckBoxContent", typeof(string), typeof(CheatLocker), new PropertyMetadata(default(string)));

        public CheatLocker()
        {
            InitializeComponent();
        }

        public bool IsLocked
        {
            get => (bool) GetValue(IsLockedProperty);
            set => SetValue(IsLockedProperty, value);
        }

        public string CheckBoxContent
        {
            get => (string) GetValue(CheckBoxContentProperty);
            set => SetValue(CheckBoxContentProperty, value);
        }
    }
}