using System.Windows;
using System.Windows.Controls;
using ControlCenter.Cheats.Models;

namespace ControlCenter.Cheats.Selector
{
    public class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (container is FrameworkElement element && item != null && item is Cheat cheat)
            {
                return cheat.IsFolder
                    ? (DataTemplate) element.FindResource("TreeViewFolderTemplate")
                    : (DataTemplate) element.FindResource("TreeViewCheatTemplate");
            }

            return null;
        }
    }
}