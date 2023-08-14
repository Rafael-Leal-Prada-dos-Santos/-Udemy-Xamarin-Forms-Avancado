using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7_GestosEAnimacoes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            count++;
            DisplayAlert("Toque", $"Label tocada: {count}", "OK");
        }

        //gesture
        //Tap - Toque
        //Pinch - Pinça - Galeria de imagens zoom
        //Pan - Arastar
    }
}
