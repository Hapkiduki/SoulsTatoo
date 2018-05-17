namespace SoulsTatoo.Droid
{
    using System;
    using Android.App;
    using Android.Content.PM;
    using Android.Graphics;
    using Android.OS;
    using Android.Text;
    using Android.Text.Style;
    using Android.Widget;
    using CarouselView.FormsPlugin.Android;
    using FFImageLoading.Forms.Droid;
    using Xamarin.Forms;
    using static System.Net.Mime.MediaTypeNames;

    [Activity(Label = "SoulsTatoo",
        Icon = "@drawable/ic_launcher",
        Theme = "@style/MainTheme", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnStart()
        {
            
            base.OnStart();
        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init();
            CarouselViewRenderer.Init();
        
            LoadApplication(new App());
        }
    }
}

