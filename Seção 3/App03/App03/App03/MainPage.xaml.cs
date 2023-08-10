using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button meuBotao = new Button();
            meuBotao.Text = "Eu sou diferente";
            meuBotao.TextColor = Color.Coral;

            Container.Children.Add(meuBotao);
        }
    }
}
