using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13_MultiplasFontes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lblBemVindo.FontFamily = 
                Device.OnPlatform("lourod", "lourod.ttf#lourod", "Assets/Fonts/lourod.ttf#lourod") ;
        }
    }
}
