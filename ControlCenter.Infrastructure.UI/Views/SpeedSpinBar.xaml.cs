using System.Text;
using System.Windows.Controls;

namespace ControlCenter.Infrastructure.UI.Views
{
    /// <summary>
    ///     Interaction logic for SpeedAndSpinScrollBar.xaml
    /// </summary>
    public partial class SpeedSpinBar : UserControl
    {
        public SpeedSpinBar()
        {
            InitializeComponent();
            _sb = new StringBuilder();
        }

        #region Fields & Properties
        
        private const decimal DefValToCapDecimals = 0;
        private const float DefButtonVal = 400;
        private const float DefValToCapMultiplier = 1;

        public string Title
        {
            get => TextBlock.Text + $"({Progress}%)";
            set => TextBlock.Text = value + $"({Progress}%)";
        }

        public string ButtonContent
        {
            get => Button.Content as string;
            set => Button.Content = value;
        }

        public int Progress { get; set; }
        public int ValToCapDecimals { get; set; }
        public float ButtonVal { get; set; }
        public float ValToCapMultiplier { get; set; }


        private static StringBuilder _sb;

        #endregion
    }
}