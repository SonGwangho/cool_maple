using cool_maple.API;
using cool_maple.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cool_maple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await MapleAPI.SetCharacter(this.CharacterName.Text);
            var viewModel = DataContext as MainWindowViewModel;
            if (viewModel != null)
            {
                await viewModel.SetBasic();
                await viewModel.SetPopulatity();
                await viewModel.SetUnion();
                await viewModel.SetDojang();
            }
        }
    }
}