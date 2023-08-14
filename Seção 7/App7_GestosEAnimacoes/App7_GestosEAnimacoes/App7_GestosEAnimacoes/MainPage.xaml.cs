using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7_GestosEAnimacoes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            PanGestureRecognizer pan = new PanGestureRecognizer();
            pan.PanUpdated += PanGestureRecognizer_Tapped;

            MinhaLabel.GestureRecognizers.Add(pan);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            count++;
            //DisplayAlert("Toque", $"Label tocada: {count}", "OK");

            //MeuBoxView.TranslateTo(200, 350, 1000, Easing.BounceOut);
            //MeuBoxView.ScaleTo(2, 1000);
            //MeuBoxView.FadeTo(0.5, 1000);
            //MeuBoxView.RotateTo(45, 1000, Easing.SpringOut);

            Animation animacao = new Animation(v => MeuBoxView.WidthRequest = v, 50, 100);
            animacao.Commit(this, "animacao", 16, 1000);
        }

        private void PanGestureRecognizer_Tapped(object sender, PanUpdatedEventArgs e)
        {
            if (e.StatusType == GestureStatus.Running) 
            {
                Rectangle rect = new Rectangle(e.TotalX, e.TotalY, 200, 25);

                AbsoluteLayout.SetLayoutBounds(MinhaLabel, rect);
                AbsoluteLayout.SetLayoutFlags(MinhaLabel, AbsoluteLayoutFlags.None);
            }
        }

        //gesture
        //Tap - Toque
        //Pinch - Pinça - Galeria de imagens zoom
        //Pan - Arastar
    }
}
