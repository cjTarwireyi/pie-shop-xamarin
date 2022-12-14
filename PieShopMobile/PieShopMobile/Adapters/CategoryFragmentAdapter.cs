using AndroidX.Fragment.App;
using PieShop.Core.Models;
using PieShop.Core.Repository;
using PieShopMobile.Fragments;
using System.Collections.Generic;
namespace PieShopMobile.Adapters
{
    public class CategoryFragmentAdapter : FragmentPagerAdapter
    {
        private readonly List<Category> _categories;

        public CategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {
            var pieRepository = new PieRepository();
            _categories = pieRepository.GetCategoriesWithPies();
        }
        public override int Count => _categories.Count;

        //public override Fragment GetItem(int position)
        //{
        //    throw new NotImplementedException();
        //}

        public override Fragment GetItem(int position)
        {
            PieCategoryFragment pieCategoryFragment = new PieCategoryFragment(_categories[position]);
            return pieCategoryFragment;
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_categories[position].CategoryName);
        }
    }
}