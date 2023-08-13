using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App05_ControleCustomizadoNativo.ControlesPersonalizados
{
    public class BoxViewCustomizado : BoxView
    {
        public static BindableProperty EspessuraProperty =
            BindableProperty.Create<BoxViewCustomizado, double>(
                 p => p.Espessura, default(double)
            );

        public double Espessura
        {
            get { return (double)GetValue(EspessuraProperty); }
            set { SetValue(EspessuraProperty, value); }
        }
    }
}
