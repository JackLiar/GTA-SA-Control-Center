using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using ControlCenter.Infrastructure;
using ControlCenter.Views;
using Microsoft.Practices.Unity;
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
            // check config files and data files
            await Task.Run(() => CheckPrerequisite());

            Application.Current.MainWindow?.Show();
        }

        private void CheckPrerequisite()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var temp = assembly.GetManifestResourceNames();
            using (var stream = assembly.GetManifestResourceStream("ControlCenter.GTASAConsole.ini"))
            {
                using (var fileStream = File.Create(@".\GTASAConsole.ini"))
                {
                    stream?.CopyTo(fileStream);
                }
            }
        }
    }
}