using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.ViewPager.Widget;
using PieShopMobile.Adapters;

namespace PieShopMobile
{
    [Activity(Label = "PieMenuTabsActivity")]
    public class PieMenuTabsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu_tabs);
            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.piePager);
            CategoryFragmentAdapter categoryFragmentAdapter =
                new CategoryFragmentAdapter(SupportFragmentManager);
            viewPager.Adapter = categoryFragmentAdapter;
            // Create your application here
        }
    }
}