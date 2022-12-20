using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace PieShopMobile
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        private Button _phoneButton;
        private Button _emailButton;
        private EditText _feedbackText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.about);
            FindViews(); 
            LinkEventHandlers();

            // Create your application here
        }
        private void LinkEventHandlers()
        {
            _phoneButton.Click += PhoneButton_Click;
            _emailButton.Click += _emailButton_Click;
        }
        private async void _emailButton_Click(object sender, EventArgs e)
        {
            var message = new EmailMessage
            {
                Subject = "Feedback from Pie Shop mobile app",
                Body = _feedbackText.Text,
                To = new List<string> { "codzatazz@gmail.com" },                
            };
            await Email.ComposeAsync(message);
        }
        private void PhoneButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(Intent.ActionDial);
            intent.SetData(Android.Net.Uri.Parse("tel:+27749288137"));
            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void FindViews()
        {
            _phoneButton = FindViewById<Button>(Resource.Id.phoneButton);
            _emailButton = FindViewById<Button>(Resource.Id.emailButton);
            _feedbackText = FindViewById<EditText>(Resource.Id.feedbackText);

        }
    }
}