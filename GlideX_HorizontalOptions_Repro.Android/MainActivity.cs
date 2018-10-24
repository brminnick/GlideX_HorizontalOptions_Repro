using Android.App;
using Android.Content.PM;
using Android.OS;

namespace GlideX_HorizontalOptions_Repro.Droid
{
    [Activity(Label = "GlideX_HorizontalOptions_Repro", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Android.Glide.Forms.Init();

            LoadApplication(new App());
        }
    }
}