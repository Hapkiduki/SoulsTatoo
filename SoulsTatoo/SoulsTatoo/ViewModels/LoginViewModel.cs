namespace SoulsTatoo.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private void Login()
        {
            Application.Current.MainPage = new MasterPage();
        }
    }
}
