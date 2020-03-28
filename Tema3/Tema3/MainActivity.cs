using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace Tema3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {   
        public ImageView imageView1;
        public Button button1;
        public Button button2;
        public bool vb = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //imageView1 = FindViewById(Resource.Id.imageView1);
            imageView1 = FindViewById<ImageView>(Resource.Id.imageView1);
            //imageView1 = (ImageView)FindViewById(R.id.imageView1);
            //Button button = (Button)findViewById(R.id.myButton);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += Button1_Click;
            button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += Button2_Click;
        }

        private ImageView FindViewById(object imageView1)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vb)
                {
                    imageView1.SetImageResource(Resource.Drawable.head);
                    vb = !vb;
                }
                else
                {
                    imageView1.SetImageResource(Resource.Drawable.tail);
                    vb = !vb;
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(ApplicationContext, "Image error!" + ex.Message, ToastLength.Long).Show();

            }
            finally
            {
                Toast.MakeText(ApplicationContext, "Image changed", ToastLength.Long).Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                imageView1.SetImageResource(Resource.Drawable.tail);
                imageView1.Rotation += 180;
            }
            catch (NotImplementedException ex)
            {
                Toast.MakeText(ApplicationContext, ex.Message, ToastLength.Long).Show();
            }
            finally
            {
                Toast.MakeText(ApplicationContext, "Coin Flip", ToastLength.Long).Show();
            }
        }

        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}