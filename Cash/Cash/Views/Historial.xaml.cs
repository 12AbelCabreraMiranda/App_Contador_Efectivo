using Cash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cash.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Historial : ContentPage
    {
        public Historial()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItems();
        }

        private async void LoadItems()
        {
            var items = await App.Context.GetItemsAsync();
            lista_tareas.ItemsSource = items;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Confirmación", "¿Está seguro de eliminar el elemento?", "Si", "No"))
            {
                var item = (CashItem)(sender as MenuItem).CommandParameter;
                var result = await App.Context.DeleteItemAzync(item);

                if (result == 1)
                {
                    LoadItems();
                }
            }
        }
    }
}