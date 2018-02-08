using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlCenter.Locations.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            Loaded += SetScrollViewerToCenter;
        }

        private void SetScrollViewerToCenter(object sender, RoutedEventArgs e)
        {
            ScrollViewer.ScrollToHorizontalOffset((Map.ActualWidth - ScrollViewer.Width) / 2);
            ScrollViewer.ScrollToVerticalOffset((Map.ActualHeight - ScrollViewer.Height) / 2);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var basicX = ScrollViewer.Width / 2;
            var basicY = ScrollViewer.Width / 2;

            var actualX = ScrollViewer.HorizontalOffset + basicX;
            var actualY = ScrollViewer.VerticalOffset + basicY;

            var scaledX = actualX / e.OldValue * e.NewValue;
            var scaledY = actualY / e.OldValue * e.NewValue;

            var offsetX = scaledX - basicX;
            var offsetY = scaledY - basicY;

            ScrollViewer.ScrollToHorizontalOffset(offsetX);
            ScrollViewer.ScrollToVerticalOffset(offsetY);
        }
    }
}
