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
        }

        private void Button_Clicked(object sender, EventArgs e)
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
}
