using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace App15_Mapas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Map mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-23.9798288, -46.3082321), Distance.FromKilometers(1)));

            mapa.MapType = MapType.Street;
            mapa.IsShowingUser = true;

            Pin artigo180 = new Pin() 
            {
                Position = new Position(-23.9791734, -46.3046702),
                Label = "Atrigo 180",
                Address = "R. Ricardo Pinto, 180 - Aparecida, Santos - SP, 11035-170"
            };

            Pin brasilFC = new Pin()
            {
                Position = new Position(-23.977591, -46.3049547),
                Label = "Brasil Futebol Clube",
                Address = "R. Jurubatuba, 80 - Aparecida, Santos - SP, 11035-100"
            };

            mapa.Pins.Add(artigo180);
            mapa.Pins.Add(brasilFC);

            MapaConteiner.Children.Add(mapa);
        }
    }
}
