using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using PieShopMobile.Adapters;

namespace PieShopMobile
{
    [Activity(Label = "PieMenuActivity", MainLauncher = false)]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _pieRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu);
            _pieRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);

            //_pieLayoutManager = new LinearLayoutManager(this);
            _pieLayoutManager = new GridLayoutManager(this, 2, GridLayoutManager.Horizontal, false);
            _pieRecyclerView.SetLayoutManager(_pieLayoutManager);

            _pieAdapter = new PieAdapter();
            _pieRecyclerView.SetAdapter(_pieAdapter);

            // Create your application here
        }
    }
}