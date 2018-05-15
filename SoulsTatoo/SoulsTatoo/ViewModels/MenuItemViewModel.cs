namespace SoulsTatoo.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MenuItemViewModel
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private void Navigate()
        {
            if (this.PageName == "LoginPage")
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}
