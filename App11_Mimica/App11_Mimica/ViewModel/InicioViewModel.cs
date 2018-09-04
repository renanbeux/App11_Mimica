﻿using System;
using System.Collections.Generic;
using System.Text;
using App11_Mimica.Model;
using System.ComponentModel;
using Xamarin.Forms;

namespace App11_Mimica.ViewModel
{
    public class InicioViewModel:INotifyPropertyChanged
    {
        public Jogo jogo {get;set;}
        public Command IniciarCommand { get; set; }

        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
        }

        private void IniciarJogo()
        {
            App.Current.MainPage = new View.Jogo();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
