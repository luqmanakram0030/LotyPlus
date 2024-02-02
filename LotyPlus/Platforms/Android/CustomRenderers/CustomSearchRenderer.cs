using System;
using Android.Content;
using Android.Content.Res;
using Android.Views;
using Android.Widget;
using LotyPlus.CustomControls;
using LotyPlus.Platforms.Android.CustomRenderers;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;


[assembly: ExportRenderer(typeof(CustomSearch), typeof(CustomSearchRenderer))]
namespace LotyPlus.Platforms.Android.CustomRenderers
{
    public class CustomSearchRenderer : SearchBarRenderer
    {
        public CustomSearchRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
                var plate = Control.FindViewById(plateId);
                plate.SetBackgroundColor(Colors.Transparent.ToAndroid());

                var searchView = base.Control as AndroidX.AppCompat.Widget.SearchView;

                //Get the Id for your search icon
                int searchIconId = Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
                ImageView searchViewIcon = (ImageView)searchView.FindViewById<ImageView>(searchIconId);
                ViewGroup linearLayoutSearchView = (ViewGroup)searchViewIcon.Parent;
                searchViewIcon.SetAdjustViewBounds(true);

                //Get the Id for your search clear icon
                int searchClearIconId = Context.Resources.GetIdentifier("android:id/search_close_btn", null, null);
                ImageView searchClearIcon = (ImageView)searchView.FindViewById<ImageView>(searchClearIconId);
                searchClearIcon.SetColorFilter(Colors.Purple.ToAndroid());

                //Remove the search icon from the view group
                linearLayoutSearchView.RemoveView(searchViewIcon);
            }
        }
    }
}
