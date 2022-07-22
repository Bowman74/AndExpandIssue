using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndExpandIssue
{
    public class MainPage : BasePage
    {
        public MainPage()
        {
            var oStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var oLabel = new Label
            {
                Text = "foo"
            };

            oStackLayout.Children.Add(oLabel);

            this.PageContent = oStackLayout;

            InitView();
        }
    }
}