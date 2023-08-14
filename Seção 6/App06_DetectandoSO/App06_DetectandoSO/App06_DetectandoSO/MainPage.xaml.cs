using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App06_DetectandoSO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == TargetPlatform.iOS.ToString()) { 
                Container.Margin = new Thickness(0, 10, 0, 0);
            }

            if (Device.Idiom == TargetIdiom.Tablet) 
            {
                Container.BackgroundColor = Color.Aqua;
            }

            /*
                 Device.OnPlatform(
                    iOS: () => {
                        Margin = new Thickness(0,10,0,0);
                     },
                    Android: () => {
            
                    },
                    WinPhone: () =>{
                    }
                  );
             */

        }
    }
}
