using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App04_CustomControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MeuControlePersonalizado_Tocado(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Sou um evento", "Ok.");
        }
    }
}
