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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        

        private async void BtnHistorial_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Historial());
        }

        
    }
}