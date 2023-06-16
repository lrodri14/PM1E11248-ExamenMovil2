using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM2E11248.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E11248.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLugaresGrid : ContentPage
    {
        public PageLugaresGrid()
        {
            InitializeComponent();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listalugares.ItemsSource = await App.Instancia.GetAll();
        }

        private async void mapa(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageLugaresMapa());
        }

        private async void agregar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageLugares());
        }

        private async void lista(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageListLugares());
        }

        private async void cambio(object sender, SelectedItemChangedEventArgs e)
        {
          
        }
    }
}