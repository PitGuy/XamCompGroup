using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCompetenceGroup.CustomControls
{
    public class TagLabel : Label
    {
        public static readonly BindableProperty TagProperty =
            BindableProperty.Create("Tag",
                typeof(string),
                typeof(TagLabel),
                "0"
            );

        public string Tag
        {
            set
            {
                SetValue(TagProperty, value);
            }
            get
            {
                return (string)GetValue(TagProperty);
            }
        }
    }
}
