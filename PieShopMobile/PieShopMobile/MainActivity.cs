using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace PieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _orderButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            FindViews();
            LinkEventHandlers();

        }
        private void LinkEventHandlers()
        {
            _orderButton.Click += _orderButton_Click;
        }

        private void _orderButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuActivity));
            StartActivity(intent);
        }

        private void FindViews()
        {
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }
        private void MyButton_Click(object sender, EventArgs e)
        {
            //var toast = Toast.MakeText(this, "A button was clicked", ToastLength.Short);
            //toast.Show();
            //Intent intent = new Intent(this, typeof(Activity1));
            //StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}