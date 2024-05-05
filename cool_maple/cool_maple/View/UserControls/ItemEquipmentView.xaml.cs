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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cool_maple.View
{
    /// <summary>
    /// ItemEquipmentView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ItemEquipmentView : UserControl
    {
        private EquipmentModalView modal;
        public ItemEquipmentView()
        {
            InitializeComponent();
        }

        private void Btn_MouseClick(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            Button ClickedButton = (Button)sender;
            vm.ClickedEquipIndex = Int32.Parse(ClickedButton.Name.Replace("Btn", ""));
            if (modal is null)
            {
                modal = new();
                modal.Show();
            }
            else
            {
                modal.Visibility = Visibility.Visible;
                modal.Activate();
            }
            e.Handled = true;
        }

        private void Grid_MouseClick(object sender, RoutedEventArgs e)
        {
            if(modal is not null)
            {
                modal.Hide();
            }
        }
    }
}
