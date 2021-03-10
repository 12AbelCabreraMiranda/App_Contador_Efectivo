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
    }
}