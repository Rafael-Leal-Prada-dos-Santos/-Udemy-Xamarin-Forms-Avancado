using App03.iOS;
using App03.Personalizado;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MeuBotaoPersonalizado), typeof(MeuBotaoPersonalizadoRenderer))]
namespace App03.iOS
{
    public class MeuBotaoPersonalizadoRenderer: ButtonRenderer
    {
        public MeuBotaoPersonalizadoRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 10;
                Control.ClipsToBounds = true;
            }
        }
    }
}