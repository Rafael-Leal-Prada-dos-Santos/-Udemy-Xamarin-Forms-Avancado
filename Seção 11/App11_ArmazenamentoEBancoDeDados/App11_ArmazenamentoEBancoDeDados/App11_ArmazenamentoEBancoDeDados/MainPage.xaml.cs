using PCLStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11_ArmazenamentoEBancoDeDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Escrever_Clicado(object sender, EventArgs e)
        {
            Util.GerenciadorArmazenamento.SalvarArquivo("arquivo.txt", txtConteudo.Text);
        }

        private async void LerArquivo_Clicado(object sender, EventArgs e)
        {
           string conteudo = await  Util.GerenciadorArmazenamento.LerArquivo("arquivo.txt");

           lblConteudoArquivo.Text = conteudo;
        }
    }
}
