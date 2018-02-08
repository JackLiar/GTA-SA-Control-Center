using System.Windows.Controls;

namespace ControlCenter.Infrastructure.UI.Views
{
    /// <summary>
    /// Interaction logic for Direction.xaml
    /// </summary>
    public partial class Direction : UserControl
    {
        public Direction()
        {
            InitializeComponent();
        }

        #region Files & Properties

        /// <summary>
        /// Direction User Control's Title
        /// </summary>
        public string Title
        {
            get => TextBlock.Text;
            set => TextBlock.Text = value;
        }

        /// <summary>
        /// Direction User Control's Button's Text
        /// </summary>
        public string Text
        {
            get => Button.Content as string;
            set => Button.Content = value;
        }

        #endregion
    }
}
