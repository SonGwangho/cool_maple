using cool_maple.ViewModel;
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
using System.Windows.Shapes;

namespace cool_maple.View
{
    /// <summary>
    /// EquipmentModalView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EquipmentModalView : Window
    {
        public MainWindowViewModel mainViewModel { get; set; }

        public EquipmentModalView()
        {
            InitializeComponent();
            var parentWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (parentWindow != null)
            {
                var parentViewModel = (MainWindowViewModel)parentWindow.DataContext;
                mainViewModel = parentViewModel;
            }
        }

        private async void Window_Activated(object sender, EventArgs e)
        {
            var equipViewModel = DataContext as EquipmentModalViewModel;
            await equipViewModel.SetModal(mainViewModel);
            var mainWindow = Application.Current.MainWindow;

            Left = mainWindow.Left + mainWindow.Width + 5;
            Top = mainWindow.Top + 100;
            HeightResize();
        }

        private void HeightResize()
        {
            var equipViewModel = DataContext as EquipmentModalViewModel;
            int height = 740;

            if (equipViewModel.ModalProperties.PotentialOptionGrade is null || equipViewModel.ModalProperties.PotentialOptionGrade == "")
            {
                height -= 98;
            }

            if (equipViewModel.ModalProperties.AdditionalPotentialOptionGrade is null || equipViewModel.ModalProperties.AdditionalPotentialOptionGrade == "")
            {
                height -= 95;
            }

            if (equipViewModel.ModalProperties.SoulName is null || equipViewModel.ModalProperties.SoulName == "")
            {
                height -= 55;
            }

            Height = height;
        }
    }
}
