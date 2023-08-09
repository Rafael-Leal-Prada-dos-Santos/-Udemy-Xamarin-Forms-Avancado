using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListaFuncionarios.ItemsSource = ObterFuncionarios();
        }

        private List<Grupo> ObterFuncionarios()
        {
            return new List<Grupo>()
            {

                new Grupo("Presidentes", "CEO", "Presidente da empresa")
                {
                    new Pessoa(){ Nome = "Rafael"},
                    new Pessoa(){ Nome = "Renato"},
                },
                new Grupo("Diretores", "Dir.", "Diretor da empresa")
                {
                    new Pessoa(){ Nome = "Richard"},
                    new Pessoa(){ Nome = "Brenno"},
                },
                 new Grupo("Gerentes", "Ger.", "Gerente da empresa")
                {
                    new Pessoa(){ Nome = "Ivaldo"},
                    new Pessoa(){ Nome = "Luiz"}
                },
                new Grupo("Colaboradores", "Colab.", "Colaboradores da empresa")
                {
                    new Pessoa(){ Nome = "Daniel"},
                    new Pessoa(){ Nome = "Debora"},
                    new Pessoa(){ Nome = "Alex"},
                    new Pessoa(){ Nome = "Vander"},
                    new Pessoa(){ Nome = "Milton"},
                }
            };
        }

        public class Grupo : List<Pessoa> {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

            public Grupo(string titulo, string tituloCurto, string descricao) 
            {
                this.Titulo = titulo;
                this.TituloCurto = tituloCurto;
                this.Descricao = descricao;
            }
        }


        public class Pessoa 
        {
            public string Nome { get; set; }
        }
    }
}
