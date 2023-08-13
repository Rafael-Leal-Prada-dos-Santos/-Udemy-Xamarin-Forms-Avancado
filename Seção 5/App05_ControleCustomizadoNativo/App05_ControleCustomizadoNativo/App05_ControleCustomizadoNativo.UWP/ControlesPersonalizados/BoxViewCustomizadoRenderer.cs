using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;
using App05_ControleCustomizadoNativo.ControlesPersonalizados;
using Windows.UI.Xaml.Shapes;
using App05_ControleCustomizadoNativo.UWP.ControlesPersonalizados;

[assembly:ExportRenderer(typeof(BoxViewCustomizadoRenderer), typeof(BoxViewCustomizado))]
namespace App05_ControleCustomizadoNativo.UWP.ControlesPersonalizados
{
    public class BoxViewCustomizadoRenderer : BoxViewBorderRenderer
    {
        public BoxViewCustomizadoRenderer() 
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var border = new Border();
                border.Child = new Canvas();

                SetNativeControl(border);

                BoxViewCustomizado controle = (BoxViewCustomizado)Element;
                DrawShapes(border, controle);
            }
        }

        private void DrawShapes(Border border, BoxViewCustomizado boxView)
        {
            var canvas = (Canvas)border.Child;

            var rect = new Windows.UI.Xaml.Shapes.Rectangle
            {
                Width = 200,
                Height = 200,
                Fill = new Xamarin.Forms.SolidColorBrush(Xamarin.Forms.Color.White).ToBrush(),
                Stroke = new Xamarin.Forms.SolidColorBrush(Xamarin.Forms.Color.Black).ToBrush(),
                StrokeThickness = boxView.Espessura
            };

            Canvas.SetLeft(rect, 0);
            Canvas.SetTop(rect, 0);

            var line1 = new Line
            {
                X1 = 100,
                Y1 = 0,
                X2 = 100,
                Y2 = 200,
                Stroke = new Xamarin.Forms.SolidColorBrush(Xamarin.Forms.Color.Black).ToBrush(),
                StrokeThickness = boxView.Espessura
            };

            var line2 = new Line
            {
                X1 = 0,
                Y1 = 100,
                X2 = 200,
                Y2 = 100,
                Stroke = new Xamarin.Forms.SolidColorBrush(Xamarin.Forms.Color.Black).ToBrush(),
                StrokeThickness = boxView.Espessura
            };

            canvas.Children.Add(line1);
            canvas.Children.Add(line2);
            canvas.Children.Add(rect);
        }

        private Windows.UI.Color ToWindowsColor(Color color)
        {
            return Windows.UI.Color.FromArgb((byte)(color.A * 255), (byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255));
        }


    }
}
