using cool_maple.API;
using cool_maple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.ViewModel
{
    public class EquipmentModalViewModel : INotifyPropertyChanged
    {
        private ItemEquipmentModel _modalProperties;
        public ItemEquipmentModel ModalProperties
        {
            get { return _modalProperties; }
            set
            {
                _modalProperties = value;
                OnPropertyChanged(nameof(ModalProperties));
            }
        }
        public async Task SetModal(MainWindowViewModel vm)
        {
            ModalProperties = vm.CharacterItemEquipmentProperties.ItemEquipment[vm.ClickedEquipIndex];
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
}
