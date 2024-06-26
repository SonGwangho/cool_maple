﻿using cool_maple.API;
using cool_maple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.ViewModel
{
    public class CharacterBasicViewModel : INotifyPropertyChanged
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

        public async Task SetBasic()
        {
            var response = await MapleAPI.GetBasic();
            BasicProperties = response;
        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}