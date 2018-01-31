using System.Windows;
using System.Windows.Controls;
using ControlCenter.Locations.Models;

namespace ControlCenter.Locations.Selectors
{
    public class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (container is FrameworkElement element && item != null && item is Location location)
            {
                return location.IsFolder
                    ? (DataTemplate) element.FindResource("TreeViewFolderTemplate")
                    : (DataTemplate) element.FindResource("TreeViewLocationTemplate");
            }

            return null;
        }
    }
}