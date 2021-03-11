using Cash.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Inicialización de campos en cero
            veintiCincoCentavos.Text = "0";
            cincuentaCentavos.Text = "0";
            unQuetzal.Text = "0";
            cincoQuetzales.Text = "0";
            diezQuetzales.Text = "0";
            veinteQuetzales.Text = "0";
            cincuentaQuetzales.Text = "0";
            cienQuetzales.Text = "0";
        }

        //Calcula los registros de los campos
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(veintiCincoCentavos.Text) &&
               !string.IsNullOrEmpty(cincuentaCentavos.Text) &&
               !string.IsNullOrEmpty(unQuetzal.Text) &&
               !string.IsNullOrEmpty(cincoQuetzales.Text) &&
               !string.IsNullOrEmpty(diezQuetzales.Text) &&
               !string.IsNullOrEmpty(veinteQuetzales.Text) &&
               !string.IsNullOrEmpty(cincuentaQuetzales.Text) &&
               !string.IsNullOrEmpty(cienQuetzales.Text))
            {
                var e25Cent = double.Parse(veintiCincoCentavos.Text);
                var e50Cent = double.Parse(cincuentaCentavos.Text);
                var e1Quetzal = double.Parse(unQuetzal.Text);
                var e5Quetzal = double.Parse(cincoQuetzales.Text);
                var e10Quetzal = double.Parse(diezQuetzales.Text);
                var e20Quetzal = double.Parse(veinteQuetzales.Text);
                var e50Quetzal = double.Parse(cincuentaQuetzales.Text);
                var e100Quetzal = double.Parse(cienQuetzales.Text);

                if (e25Cent < 0 || e50Cent < 0 || e1Quetzal < 0 || e5Quetzal < 0 || e10Quetzal < 0 || e20Quetzal < 0 || e50Quetzal < 0 || e100Quetzal < 0)
                {
                    //DisplayAlert("Número inválido: ", "Las cantidades deben ser positivos", "Ok");
                    if (e25Cent < 0)
                    {
                        await DisplayAlert("Cantidad 25 Centavos: "+ e25Cent, "El valor debe ser positivo", "Ok");
                    }
                    if (e50Cent < 0)
                    {
                        await DisplayAlert("Cantidad 50 Centavos: " + e50Cent, "El valor debe ser positivo", "Ok");
                    }
                    if (e1Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 1 Quetzal: " + e1Quetzal, "El valor debe ser positivo", "Ok");
                    }
                    if (e5Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 5 Quetzales: " + e5Quetzal, "El valor debe ser positivo", "Ok");
                    }
                    if (e10Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 10 Quetzales: " + e10Quetzal, "El valor debe ser positivo", "Ok");
                    }
                    if (e20Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 20 Quetzales: " + e20Quetzal, "El valor debe ser positivo", "Ok");
                    }
                    if (e50Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 50 Quetzales: " + e50Quetzal, "El valor debe ser positivo", "Ok");
                    }
                    if (e100Quetzal < 0)
                    {
                        await DisplayAlert("Cantidad 100 Quetzales: " + e100Quetzal, "El valor debe ser positivo", "Ok");
                    }
                }
                else
                {
                    var total25Centavo = double.Parse(veintiCincoCentavos.Text) / 4;
                    var total50Centavos = double.Parse(cincuentaCentavos.Text) / 2;
                    var totalQuetzal = double.Parse(unQuetzal.Text);
                    var total5Quetzales = double.Parse(cincoQuetzales.Text) * 5;
                    var total10Quetzales = double.Parse(diezQuetzales.Text) * 10;
                    var total20Quetzales = double.Parse(veinteQuetzales.Text) * 20;
                    var total50Quetzales = double.Parse(cincuentaQuetzales.Text) * 50;
                    var total100Quetzales = double.Parse(cienQuetzales.Text) * 100;
                
                    double totalEfectivo = total25Centavo + total50Centavos + totalQuetzal + total5Quetzales + total10Quetzales + total20Quetzales + total50Quetzales + total100Quetzales;
                    miEfectivo.Text = totalEfectivo.ToString();                    
                }
            }
            else
            {
                await DisplayAlert("Hay campos vacíos", "Los campos que no utiliza, dejarlo en cero", "Ok");
            }
        }

        //Guarda en Historial
        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            //Guarda registro en la Base de Datos Local

            //DateTime fecha = DateTime.Now;
            var fecha = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");

            var item = new CashItem
            {
                TotalEfectivoMes = double.Parse(miEfectivo.Text),
                FechaRegistrado = fecha
            };
            await App.Context.InsertItemAsync(item);

            //Inicialización de campos en cero
            veintiCincoCentavos.Text = "0";
            cincuentaCentavos.Text = "0";
            unQuetzal.Text = "0";
            cincoQuetzales.Text = "0";
            diezQuetzales.Text = "0";
            veinteQuetzales.Text = "0";
            cincuentaQuetzales.Text = "0";
            cienQuetzales.Text = "0";

            miEfectivo.Text = "0";
            //Mensage de registro almacenado
            await DisplayAlert("Registrado", "Total Efectivo guardado en historial", "Ok");
        }
        //Limpia los campos
        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            //Inicialización de campos en cero
            veintiCincoCentavos.Text = "0";
            cincuentaCentavos.Text = "0";
            unQuetzal.Text = "0";
            cincoQuetzales.Text = "0";
            diezQuetzales.Text = "0";
            veinteQuetzales.Text = "0";
            cincuentaQuetzales.Text = "0";
            cienQuetzales.Text = "0";

            miEfectivo.Text = "0";
        }                
    }
}
