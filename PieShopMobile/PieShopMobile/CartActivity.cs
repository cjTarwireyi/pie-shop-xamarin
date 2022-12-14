using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using PieShopMobile.Adapters;

namespace PieShopMobile
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private RecyclerView _cartRecyclerView;
        private RecyclerView.LayoutManager _cartLayoutManager;
        private ShoppingCartAdapter _shoppingCartAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cart);

            _cartRecyclerView = FindViewById<RecyclerView>(Resource.Id.cartRecyclerView);

            // Create your application here
        }
    }
}