using System.Threading.Tasks;
using System.Windows;
using ControlCenter.Infrastructure;
using ControlCenter.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;

namespace ControlCenter
{
    internal class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override async void InitializeShell()
        {
            await Task.Run(() => Prerequisite.Check());

            Application.Current.MainWindow?.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}