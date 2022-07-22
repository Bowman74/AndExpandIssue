using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace AndExpandIssue;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        base.OnCreate(savedInstanceState);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        // Exception details can be viewed here
        var a = e;
    }
}
