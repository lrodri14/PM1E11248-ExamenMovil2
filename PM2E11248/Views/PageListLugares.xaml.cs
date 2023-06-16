using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PM2E11248.Models;
using Xamarin.Forms;

namespace PM2E11248.Views
{
    public partial class PageListLugares : ContentPage
    {

        private Lugares selectedLugar;

        public PageListLugares()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            list.ItemsSource = await App.Instancia.GetAll();
        }

        private void foto(object sender, EventArgs e)
        {
           
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
            await Navigation.PushAsync(new Views.PageLugaresGrid());
        }

        private void cambio(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                selectedLugar = (Lugares)e.CurrentSelection[0];
            }
        }

        private async void borrar(object sender, EventArgs e)
        {
            if (selectedLugar != null)
            {
                await App.Instancia.DeleteLugar(selectedLugar);
                await DisplayAlert("Success", "Lugar deleted successfully.", "OK");
                list.ItemsSource = await App.Instancia.GetAll();
            }
        }
    }
}
