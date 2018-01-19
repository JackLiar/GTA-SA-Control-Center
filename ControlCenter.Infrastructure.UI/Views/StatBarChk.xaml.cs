using System.Text;
using System.Windows.Controls;

namespace ControlCenter.Infrastructure.UI.Views
{
    /// <summary>
    ///     Interaction logic for SpeedAndSpinScrollBar.xaml
    /// </summary>
    public partial class StatBarChk : UserControl
    {
        public StatBarChk()
        {
            InitializeComponent();
            _sb = new StringBuilder();
        }

        #region Fields & Properties
        
        private const decimal DefValToCapDecimals = 0;
        private const float DefButtonVal = 400;
        private const float DefValToCapMultiplier = 1;

        public string CheckBoxContent
        {
            get => CheckBox.Content.ToString();
            set => CheckBox.Content = value;
        }

        public string ButtonContent
        {
            get => Button.Content as string;
            set => Button.Content = value;
        }

        public string ButtonToolTip
        {
            get => Button.ToolTip as string;
            set => Button.ToolTip = value;
        }

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