using System;
using System.Windows.Input;
using Xam.ViewModels;
using Xamarin.Essentials;

namespace Xam.Models.MainPageCommand
{

    public class MainPageCommandEnableLamp : ICommand
    {

        public const string OnLamp = "Enable Lamp ON";
        private const string OffLamp = "Enable Lamp OFF";
        private MainPageViewModels _mainPageView;

        public MainPageViewModels MainPageView
        {
            get => _mainPageView;
            set => _mainPageView = value;
        }

        private bool _flagOnLamp = true;

       
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute (object parameter)
        {
            switch (_flagOnLamp)
            {
                case true:
                    _flagOnLamp = false;
                    _mainPageView.TextButtonEnableLamp = OffLamp;
                    Flashlight.TurnOnAsync();
                    break;
                case false:
                    _flagOnLamp = true;
                    _mainPageView.TextButtonEnableLamp = OnLamp;
                    Flashlight.TurnOffAsync();
                    break;
            }
        }

        public event EventHandler CanExecuteChanged;

    }

}
