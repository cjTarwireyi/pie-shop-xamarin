using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using PieShopMobile.Resources.layout;
using System;

namespace PieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _orderButton;
        private Button _cartButton;
        private Button _aboutButton;
        private Button _tabsOrderButton;
        private Button _shopLocationButton;
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
            _cartButton.Click += CartButton_Click;
            _orderButton.Click += OrderButton_Click;
            _aboutButton.Click += AboutButton_Click;
            _tabsOrderButton.Click += TabsOrderButton_Click;
            _shopLocationButton.Click += ShopLocationButton_Click;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }
        private void ShopLocationButton_Click(object sender, EventArgs e)
        {
            //var geoLocation = Android.Net.Uri.Parse("geo:-33.88897419071586, 18.514112692539168");
            //Intent intent = new Intent(Intent.ActionView, geoLocation);
            //StartActivity(intent);
            Intent intent = new Intent(this, typeof(MapActivity));
            StartActivity(intent);
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuActivity));
            StartActivity(intent);
        }
        private void TabsOrderButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuTabsActivity));
            StartActivity(intent);
        }
        private void FindViews()
        {
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
            _cartButton = FindViewById<Button>(Resource.Id.cartButton);
            _aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            _tabsOrderButton = FindViewById<Button>(Resource.Id.tabsOrderButton);
            _shopLocationButton = FindViewById<Button>(Resource.Id.shopLocationButton);
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