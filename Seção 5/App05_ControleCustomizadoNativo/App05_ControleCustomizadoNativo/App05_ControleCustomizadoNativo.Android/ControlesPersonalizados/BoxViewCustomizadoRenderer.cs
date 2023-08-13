using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using App05_ControleCustomizadoNativo.ControlesPersonalizados;
using App05_ControleCustomizadoNativo.Droid.ControlesPersonalizados;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(BoxViewCustomizadoRenderer), typeof(BoxViewCustomizado))]
namespace App05_ControleCustomizadoNativo.Droid.ControlesPersonalizados
{
    public class BoxViewCustomizadoRenderer: BoxRenderer
    {
        public BoxViewCustomizadoRenderer(Context context) : base(context)
        {
            //Por padrão ele não executa o método draw definido
            //então temos que dizer a plataforma para utilzar nossa implementação
            SetWillNotDraw(false);
        }
        
        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            Paint pintura = new Paint();

            BoxViewCustomizado controle = (BoxViewCustomizado)Element;

            pintura.StrokeWidth = (float)controle.Espessura;
            pintura.Color = Android.Graphics.Color.Black;
            pintura.SetStyle(Paint.Style.Stroke);
          

            canvas.DrawRect(0, 0, 200, 200, pintura);

            canvas.DrawLine(100, 0, 100, 200, pintura);

            canvas.DrawLine(0, 100, 200, 100, pintura);

          
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Invalidate();
        }
    }
}