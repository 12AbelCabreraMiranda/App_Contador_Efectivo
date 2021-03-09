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

        private void Button_Clicked(object sender, EventArgs e)
        {
            var e25Cent = double.Parse(veintiCincoCentavos.Text);
            var e50Cent = double.Parse(cincuentaCentavos.Text);
            var e1Quetzal = double.Parse(unQuetzal.Text);
            var e5Quetzal = double.Parse(cincoQuetzales.Text);
            var e10Quetzal = double.Parse(diezQuetzales.Text);
            var e20Quetzal = double.Parse(veinteQuetzales.Text);
            var e50Quetzal = double.Parse(cincuentaQuetzales.Text);
            var e100Quetzal = double.Parse(cienQuetzales.Text);

            if (!string.IsNullOrEmpty(veintiCincoCentavos.Text) &&
               !string.IsNullOrEmpty(cincuentaCentavos.Text) &&
               !string.IsNullOrEmpty(unQuetzal.Text) &&
               !string.IsNullOrEmpty(cincoQuetzales.Text) &&
               !string.IsNullOrEmpty(diezQuetzales.Text) &&
               !string.IsNullOrEmpty(veinteQuetzales.Text) &&
               !string.IsNullOrEmpty(cincuentaQuetzales.Text) &&
               !string.IsNullOrEmpty(cienQuetzales.Text))
            {
                if (e25Cent < 0 || e50Cent < 0 || e1Quetzal < 0 || e5Quetzal < 0 || e10Quetzal < 0 || e20Quetzal < 0 || e50Quetzal < 0 || e100Quetzal < 0)
                {
                    //DisplayAlert("Número inválido: ", "Las cantidades deben ser positivos", "Ok");
                    if (e25Cent < 0)
                    {
                        DisplayAlert("Número negativo: "+ e25Cent, "Las cantidades deben ser positivos", "Ok");
                    }
                    if (e5Quetzal < 0)
                    {
                        DisplayAlert("Número negativo: " + e5Quetzal, "Las cantidades deben ser positivos", "Ok");
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
                DisplayAlert("Datos Inválidos", "Los campos que no utiliza, dejarlo en cero", "Ok");
            }



        }
    }
}
