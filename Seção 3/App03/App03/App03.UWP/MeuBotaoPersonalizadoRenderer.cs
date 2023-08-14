using App03.Personalizado;
using App03.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(MeuBotaoPersonalizado), typeof(MeuBotaoPersonalizadoRenderer))]
namespace App03.UWP
{
    public class MeuBotaoPersonalizadoRenderer : ButtonRenderer
    {

        public MeuBotaoPersonalizadoRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                this.Control.BackgroundColor = new SolidColorBrush(Xamarin.Forms.Color.Red).ToBrush();
            }
        }
    }
}
