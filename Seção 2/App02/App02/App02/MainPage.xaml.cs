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
                    new Pessoa(){ Nome = "Rafael", EhObrigatorio=true, Eficiencia = 8},
                },
                new Grupo("Diretores", "Dir.", "Diretor da empresa")
                {
                    new Pessoa(){ Nome = "Richard" , EhObrigatorio=false},
                    new Pessoa(){ Nome = "Brenno",  EhObrigatorio=true, Eficiencia = 8},
                },
                 new Grupo("Gerentes", "Ger.", "Gerente da empresa")
                {
                    new Pessoa(){ Nome = "Ivaldo" , EhObrigatorio=true, Eficiencia = 7},
                    new Pessoa(){ Nome = "Luiz" , EhObrigatorio=false, Eficiencia = 9}
                },
                new Grupo("Colaboradores", "Colab.", "Colaboradores da empresa")
                {
                    new Pessoa(){ Nome = "Daniel" , EhObrigatorio=false},
                    new Pessoa(){ Nome = "Debora" , EhObrigatorio=false},
                    new Pessoa(){ Nome = "Alex" , EhObrigatorio=false},
                    new Pessoa(){ Nome = "Vander" , EhObrigatorio=false},
                    new Pessoa(){ Nome = "Milton" , EhObrigatorio=false},
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
            public int Eficiencia { get; set; }
            public bool EhObrigatorio { get; set; }
        }
    }
}
