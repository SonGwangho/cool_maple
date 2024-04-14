using cool_maple.API;
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
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            await MapleAPI.SetCharacter("날속인건희");
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }

}
