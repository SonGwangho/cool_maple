using cool_maple.API;
using cool_maple.Model;
using System.ComponentModel;
using System.Windows;

namespace cool_maple.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private CharacterBasicModel _basicProperties;
        public CharacterBasicModel BasicProperties
        {
            get { return _basicProperties; }
            set
            {
                _basicProperties = value;
                OnPropertyChanged(nameof(BasicProperties));
            }
        }

        private CharacterItemEquipmentModel _characterItemEquipmentProperties;
        public CharacterItemEquipmentModel CharacterItemEquipmentProperties
        {
            get { return _characterItemEquipmentProperties; }
            set
            {
                _characterItemEquipmentProperties = value;
                OnPropertyChanged(nameof(CharacterItemEquipmentProperties));
            }
        }

        private CharacterSetEffectModel _setEffectProperties;
        public CharacterSetEffectModel SetEffectProperties
        {
            get { return _setEffectProperties; }
            set
            {
                _setEffectProperties = value;
                OnPropertyChanged(nameof(SetEffectProperties));
            }
        }

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

        private PopularityModel _popularityProperties;
        public PopularityModel PopularityProperties
        {
            get { return _popularityProperties; }
            set
            {
                _popularityProperties = value;
                OnPropertyChanged(nameof(PopularityProperties));
            }
        }

        private UserUnionModel _userUnionProperties;
        public UserUnionModel UserUnionProperties
        {
            get { return _userUnionProperties; }
            set
            {
                _userUnionProperties = value;
                OnPropertyChanged(nameof(UserUnionProperties));
            }
        }

        private CharacterDojangModel _characterDojangProperties;
        public CharacterDojangModel CharacterDojangProperties
        {
            get { return _characterDojangProperties; }
            set
            {
                _characterDojangProperties = value;
                OnPropertyChanged(nameof(CharacterDojangProperties));
            }
        }

        private string _buffText;
        public string BuffText
        {
            get { return _buffText; }
            set
            {
                _buffText = value;
                OnPropertyChanged(nameof(BuffText));
            }
        }

        private int _clickedEquipIndex;
        public int ClickedEquipIndex
        {
            get { return _clickedEquipIndex; }
            set
            {
                _clickedEquipIndex = value;
                OnPropertyChanged(nameof(ClickedEquipIndex));
            }
        }

        public async Task SetBasic()
        {
            var response = await MapleAPI.GetBasic();
            BasicProperties = response;
        }

        public async Task SetEquipment()
        {
            var response = await MapleAPI.getEquipment();
            CharacterItemEquipmentProperties = response;
        }

        public async Task SetEffect()
        {
            var response = await MapleAPI.getSetEffect();
            SetEffectProperties = response;
        }

        public async Task SetStat()
        {
            var response = await MapleAPI.getStat();
            CharacterStatProperties = response;
        }

        public async Task SetPopulatity()
        {
            var response = await MapleAPI.getPopularity();
            PopularityProperties = response;
        }

        public async Task SetUnion()
        {
            var response = await MapleAPI.getUnion();
            UserUnionProperties = response;
        }

        public async Task SetDojang()
        {
            var response = await MapleAPI.getCharacterDojang();
            CharacterDojangProperties = response;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}