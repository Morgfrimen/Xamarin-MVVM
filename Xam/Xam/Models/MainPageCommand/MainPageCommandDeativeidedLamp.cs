using System;
using System.Windows.Input;
using Xamarin.Essentials;

namespace Xam.Models.MainPageCommand
{

    public class MainPageCommandDeativeidedLamp : ICommand
    {
        
        public bool CanExecute (object parameter)
        {
            return true;
        }

        /// <inheritdoc />
        public void Execute (object parameter)
        {
            Flashlight.TurnOffAsync();
        }

        /// <inheritdoc />
        public event EventHandler CanExecuteChanged;
    }

}
