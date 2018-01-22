using System.Windows;
using System.Windows.Controls;

namespace ControlCenter.PlayerData.Views
{
    /// <summary>
    ///     Interaction logic for WeaponSetter.xaml
    /// </summary>
    public partial class WeaponSetter : UserControl
    {
        public static readonly DependencyProperty IsTextBoxEnableProperty =
            DependencyProperty.Register("IsTextBoxEnable", typeof(bool), typeof(WeaponSetter),
                new PropertyMetadata(true));

        public WeaponSetter()
        {
            InitializeComponent();
        }

        public bool IsTextBoxEnable
        {
            get => (bool)GetValue(IsTextBoxEnableProperty);
            set => SetValue(IsTextBoxEnableProperty, value);
        }

        public string TextBoxText
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
    }
}