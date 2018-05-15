namespace SoulsTatoo.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string PasswordPlaceholder
        {
            get { return Resource.PasswordPlaceholder; }
        }

        public static string EmailPlaceholder
        {
            get { return Resource.EmailPlaceholder; }
        }

        public static string ForgotPass
        {
            get { return Resource.ForgotPass; }
        }

        public static string Login
        {
            get { return Resource.Login; }
        }

        public static string LoginWith
        {
            get { return Resource.LoginWith; }
        }

        public static string Register
        {
            get { return Resource.Register; }
        }

        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }

        public static string MyProfile
        {
            get { return Resource.MyProfile; }
        }

        public static string Logout
        {
            get { return Resource.Logout; }
        }
    }

}
