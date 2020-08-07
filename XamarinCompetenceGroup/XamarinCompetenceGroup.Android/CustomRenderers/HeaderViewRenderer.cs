using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinCompetenceGroup.CustomControls;

[assembly: ExportRenderer(typeof(HeaderView), typeof(XamarinCompetenceGroup.Droid.CustomRenderers.HeaderViewRenderer))]
namespace XamarinCompetenceGroup.Droid.CustomRenderers
{
    public class HeaderViewRenderer : ViewRenderer<HeaderView, TextView>
    {
        public HeaderViewRenderer(Context context)
            : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<HeaderView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                TextView textView = new TextView(Context);
                textView.SetTextColor(Android.Graphics.Color.DarkGreen);
                textView.Text = "Android";
                textView.SetTextSize(ComplexUnitType.Dip, 28);

                SetNativeControl(textView);
            }
        }
    }
}