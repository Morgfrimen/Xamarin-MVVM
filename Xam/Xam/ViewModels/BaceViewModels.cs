﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xam.Annotations;


namespace Xam.ViewModels
{

    public abstract class BaceViewModels : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
