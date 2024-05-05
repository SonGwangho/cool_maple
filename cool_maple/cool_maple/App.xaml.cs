using cool_maple.Classes;
using System.Configuration;
using System.Data;
using System.Windows;

namespace cool_maple
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LocalInfo.init();
        }
    }

}
