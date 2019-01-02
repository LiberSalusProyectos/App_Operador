using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Content;

namespace App_Op.Droid
{
    [Activity(Label = "App_Op", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }


        [Activity(Label = "App_Op", Icon = "@mipmap/icon", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize, ScreenOrientation = ScreenOrientation.Portrait)]
        public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
        {
            private Intent mainIntent = null;

            public SplashActivity()
            {
                mainIntent = new Intent(Application.Context, typeof(MainActivity));
            }

            protected override void OnCreate(Bundle savedInstanceState)
            {

                base.OnCreate(savedInstanceState);

                // Inicializa Azure Mobile Apps
                

                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            }

            // Launches the startup task
            protected override void OnResume()
            {
                base.OnResume();

                StartActivity(mainIntent);
            }


        }
    }
}