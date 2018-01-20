using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ControlCenter.Infrastructure.UI.Views
{
    /// <summary>
    ///     Interaction logic for SpeedAndSpinScrollBar.xaml
    /// </summary>
    public partial class StatBar : UserControl
    {
        public StatBar()
        {
            InitializeComponent();
            _sb = new StringBuilder();
        }

        #region Fields & Properties

        private const decimal DefValToCapDecimals = 0;
        private const float DefButtonVal = 400;
        private const float DefValToCapMultiplier = 1;

        #region CheckBox

        public string CheckBoxContent { get; set; }

        public bool IsCheckBoxVisible
        {
            get => (bool)GetValue(IsCheckBoxVisibleProperty);
            set => SetValue(IsCheckBoxVisibleProperty, value);
        }

        public static readonly DependencyProperty IsCheckBoxVisibleProperty =
            DependencyProperty.Register("IsCheckBoxVisible", typeof(bool), typeof(StatBar), new PropertyMetadata(true));

        #endregion

        #region TextBlock

        public string TextBlockText { get; set; }

        public bool IsTextBlockVisible
        {
            get => (bool)GetValue(IsTextBlockVisibleProperty);
            set => SetValue(IsTextBlockVisibleProperty, value);
        }

        public static readonly DependencyProperty IsTextBlockVisibleProperty =
            DependencyProperty.Register("IsTextBlockVisible", typeof(bool), typeof(StatBar), new PropertyMetadata(false));

        #endregion

        #region Button

        public string ButtonContent
        {
            get => Button.Content as string;
            set => Button.Content = value;
        }

        public bool IsButtonVisible
        {
            get => (bool)GetValue(IsButtonVisibleProperty);
            set => SetValue(IsButtonVisibleProperty, value);
        }

        public static readonly DependencyProperty IsButtonVisibleProperty =
            DependencyProperty.Register("IsButtonVisible", typeof(bool), typeof(StatBar), new PropertyMetadata(true));

        public string ButtonToolTip
        {
            get => Button.ToolTip as string;
            set => Button.ToolTip = value;
        }

        #endregion

        public double ScrollMax
        {
            get => ScrollBar.Maximum;
            set => ScrollBar.Maximum = value;
        }

        public double ScrollMin
        {
            get => ScrollBar.Minimum;
            set => ScrollBar.Minimum = value;
        }

        public double ScrollVal
        {
            get => ScrollBar.Value;
            set
            {
                if (value <= ScrollMax && value >= ScrollMin)
                {
                    ScrollBar.Value = value;
                }
            }
        }

        public bool HasButton { get; set; } = false;
        public int ValToCapDecimals { get; set; }
        public float ButtonVal { get; set; }
        public float ValToCapMultiplier { get; set; }

        private static StringBuilder _sb;

        #endregion
    }
}