using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;

namespace PieShopMobile.ViewHolders
{
    public class PieViewHolder : RecyclerView.ViewHolder
    {
        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }
        public PieViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}