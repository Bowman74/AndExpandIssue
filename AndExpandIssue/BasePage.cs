using Microsoft.Maui.Controls.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StackLayout = Microsoft.Maui.Controls.StackLayout;

namespace AndExpandIssue
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {

        }

        public void InitView()
        {
            var oReturnValue = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var oStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
            };
            oStackLayout.Children.Add(PageContent);

            oReturnValue.Children.Add(oStackLayout,
                Constraint.RelativeToParent(parent => 0),
                Constraint.RelativeToParent(parent => 0),
                Constraint.RelativeToParent(parent => DeviceDisplay.MainDisplayInfo.Width),
                Constraint.RelativeToParent(parent => DeviceDisplay.MainDisplayInfo.Height)
            );

            Content = oReturnValue;
        }

        public View PageContent { get; set; }
    }
}