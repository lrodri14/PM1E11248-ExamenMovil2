using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PM2E11248.Views
{
    public partial class PageLugaresMapa : ContentPage
    {
        public PageLugaresMapa()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var location = await Geolocation.GetLocationAsync();
            if (location == null)
            {
                return;
            }
            var pin = new Pin()
            {
                Position = new Xamarin.Forms.Maps.Position(location.Latitude, location.Longitude),
                Label = "Ubicacion Actual"
            };

            mapa.Pins.Add(pin);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Xamarin.Forms.Maps.Position(location.Latitude, location.Longitude), Distance.FromMeters(100)));
        }

    }
}