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
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            if (this.CharacterName.Text.Length > 1) CharacterSearch();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            CharacterSearch();
        }

        private async void CharacterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CharacterSearch();
            }
        }

        private async void CharacterSearch()
        {
            try
            {
                await MapleAPI.SetCharacter(this.CharacterName.Text);
                var viewModel = DataContext as MainWindowViewModel;
                if (viewModel != null)
                {
                    await viewModel.SetBasic();
                    await viewModel.SetPopulatity();
                    await viewModel.SetUnion();
                    await viewModel.SetDojang();
                    await viewModel.SetStat();

                    viewModel.BuffText = viewModel.CharacterStatProperties.FinalStat[33].StatValue + "초" + " / " + viewModel.CharacterStatProperties.FinalStat[34].StatValue + "%";
                }
            }
            catch
            {
                MessageBox.Show("아이디 틀린듯?");
            }
        }
    }
}