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
    public class DetailStatViewModel : INotifyPropertyChanged
    {
        private CharacterStatModel _characterStatProperties;
        public CharacterStatModel CharacterStatProperties
        {
            get { return _characterStatProperties; }
            set
            {
                _characterStatProperties = value;
                OnPropertyChanged(nameof(CharacterStatProperties));
            }
        }
        public async Task SetStat()
        {
            var response = await MapleAPI.getStat();
            CharacterStatProperties = response;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
