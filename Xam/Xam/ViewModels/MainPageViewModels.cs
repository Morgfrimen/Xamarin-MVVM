using System.Windows.Input;
using Xam.Models.MainPageCommand;
using Xamarin.Forms;

namespace Xam.ViewModels
{
    /// <summary>
    /// ViewMModels MainPage
    /// </summary>
    public class MainPageViewModels : BaceViewModels
    {
        public MainPageViewModels()
        {
            mainPageCommandEnableLamp.MainPageView = this;
        }

        #region PropertyText

        string _labelVelcome = "Welcome Xamarin.Forms!";

        /// <summary>
        /// Первая Label
        /// </summary>
        public string MainPageLabelVelcome
        {
            get => _labelVelcome;
            set
            {
                _labelVelcome = value;
                this.OnPropertyChanged(nameof(this.MainPageLabelVelcome));
            }
        }


        private string textButtonEnableLamp;
        /// <summary>
        /// Текст кнопки включения лампы
        /// </summary>
        public string TextButtonEnableLamp
        {
            get => textButtonEnableLamp;
            set
            {
                textButtonEnableLamp = value;
                OnPropertyChanged(nameof(TextButtonEnableLamp));
            }
        }
        #endregion

        private MainPageCommandEnableLamp mainPageCommandEnableLamp = new MainPageCommandEnableLamp();
        public ICommand EnableLampCommand
        {
            get
            {
                TextButtonEnableLamp = MainPageCommandEnableLamp.OnLamp;
                return mainPageCommandEnableLamp;
            }
        }


    }

}
