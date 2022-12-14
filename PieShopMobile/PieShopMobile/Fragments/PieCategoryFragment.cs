using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using PieShop.Core.Models;
using PieShopMobile.Adapters;
using AndroidX.Fragment.App;

namespace PieShopMobile.Fragments
{

    public class PieCategoryFragment: Fragment
    {
        private readonly Category _category;
        public PieCategoryFragment(Category category)
        {
            _category = category;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.pie_menu_fragment, container, false);

            var categoryTextView = view.FindViewById<TextView>(Resource.Id.categoryTextView);
            categoryTextView.Text = _category.CategoryName;

            var pieRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);
            var pieLayoutManager = new LinearLayoutManager(this.Context);
            pieRecyclerView.SetLayoutManager(pieLayoutManager);

            var pieAdapter = new PieAdapter(_category);
            pieAdapter.ItemClick += PieAdapter_ItemClick;
            pieRecyclerView.SetAdapter(pieAdapter);

            return view;
        }
        private void PieAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this.Context, typeof(PieDetailActivity));
            intent.PutExtra("selectedPieId", e);
            StartActivity(intent);
        }
    }
}