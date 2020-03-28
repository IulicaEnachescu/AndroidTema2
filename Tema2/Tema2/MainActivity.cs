using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Tema2
{
    [Activity(Label = "Tema2", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };
        }
        protected override void OnStart()
        {
            base.OnStart();
            Toast.MakeText(ApplicationContext, "Mesaj de start", ToastLength.Long).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}


