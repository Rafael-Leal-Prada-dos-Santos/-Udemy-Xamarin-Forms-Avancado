using Android.Content;
using App03.Droid;
using App03.Personalizado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MeuBotaoPersonalizado), typeof(MeuBotaoPersonalizadoRenderer))]
namespace App03.Droid
{
    class MeuBotaoPersonalizadoRenderer : ButtonRenderer
    {
        public MeuBotaoPersonalizadoRenderer(Context context) : base(context) 
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null) 
            {
               Control.SetBackgroundResource(Resource.Drawable.XMLFile1);
            }
        }
    }
}