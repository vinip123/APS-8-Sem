using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Denuncias.View
{
    public class ViewMapa : ContentPage
    {
        public ViewMapa(double lat, double lon)
        {
            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Hello Page" }
            //    }
            //};
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(lat, lon), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }
    }
}
