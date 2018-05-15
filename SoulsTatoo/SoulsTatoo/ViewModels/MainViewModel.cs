namespace SoulsTatoo.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using Helpers;
    using Models;

    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        public ObservableCollection<Carousel> Carousel { get; set; }
        #endregion

        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }

        #endregion


        #region Methods
        private void LoadMenu()
        {
            this.Carousel = new ObservableCollection<Models.Carousel>();
            this.Carousel.Add(new Carousel
            {
                Image = "http://hdfreewallpaper.net/wp-content/uploads/2015/08/arm-and-shoulder-battle-tattoo-for-men-hd-free-wallpapers.jpg",
                Subimage = "ic_launcher",
                Name = "ESto es un titulo"
            });

            this.Carousel.Add(new Carousel
            {
                Image = "https://cdn.wallpapersafari.com/6/42/FwKIWJ.jpg",
                Subimage = "facebook_logo",
                Name = "ESto es un titulo2"
            });

            this.Carousel.Add(new Carousel
            {
                Image = "https://avatars.mds.yandex.net/get-pdb/234183/f637d7cb-5177-4e15-92d8-6406bcda2be4/s800",
                Subimage = "icon",
                Name = "ESto es un titulo3"
            });


            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_user",
                PageName = "HomePage",
                Title = Languages.MyProfile
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit",
                PageName = "LoginPage",
                Title = Languages.Logout
            });
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
