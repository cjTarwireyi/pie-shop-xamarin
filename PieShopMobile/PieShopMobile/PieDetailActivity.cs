using Android.App;
using Android.OS;
using Android.Widget;
using BethanysPieShopMobile.Utility;
using PieShop.Core.Models;
using PieShop.Core.Repository;
using System;

namespace PieShopMobile
{
    [Activity(Label = "PieDetailActivity", MainLauncher =false)]
    public class PieDetailActivity : Activity
    {
        private PieRepository _pieRepository;
        private Pie _selectedPie;
        private ImageView _pieImageView;
        private TextView _pieNameTextView;
        private TextView _shortDescriptionTextView;
        private TextView _descriptionTextView;
        private TextView _priceTextView;
        private EditText _amountEditText;
        private Button _addToCartButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_detail);
            _pieRepository = new PieRepository();
            var selectedPieId = Intent.Extras.GetInt("selectedPieId");
            _selectedPie = _pieRepository.GetPieById(selectedPieId);
            findViews();
            BindData();
            LinkEventHandlers();
            // Create your application here
        }
        private void LinkEventHandlers()
        {
            _addToCartButton.Click += AddToCartButton_Click;
        }

        private void BindData()
        {
            _pieNameTextView.Text = _selectedPie.Name;
            _shortDescriptionTextView.Text = _selectedPie.ShortDescription;
            _descriptionTextView.Text = _selectedPie.LongDescription;
            _priceTextView.Text = "Price: " + _selectedPie.Price;

            var imageBitmap = ImageHelper.GetImageBitmapFromUrl(_selectedPie.ImageThumbnailUrl);

            _pieImageView.SetImageBitmap(imageBitmap);
        }

        private void findViews()
        {
            _pieImageView = FindViewById<ImageView>(Resource.Id.pieImageView);
            _pieNameTextView = FindViewById<TextView>(Resource.Id.pieNameTextView);
            _shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            _descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            _priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            _amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            _addToCartButton = FindViewById<Button>(Resource.Id.addToCartButton);
        }
        public void AddToCartButton_Click(object sender, EventArgs e)
        {
            var amount = int.Parse(_amountEditText.Text);
            ShoppingCartRepository shoppingCartRepository= new ShoppingCartRepository();
            shoppingCartRepository.AddToShoppingCart(_selectedPie, amount);
            Toast.MakeText(Application.Context, "Pie added to cart", ToastLength.Long).Show();

            this.Finish();
        }
    }
}