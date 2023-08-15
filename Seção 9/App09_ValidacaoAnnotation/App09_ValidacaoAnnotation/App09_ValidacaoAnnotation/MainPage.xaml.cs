using App09_ValidacaoAnnotation.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App09_ValidacaoAnnotation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            BtnSalvar.Clicked += delegate
            {

                Pessoa pessoa = new Pessoa()
                {
                    Nome = TxtNome.Text,
                    Email = TxtEmail.Text,
                    CPF = TxtCPF.Text,
                };

                List<ValidationResult> resultadosValidacoes = new List<ValidationResult>();

                ValidationContext contexto = new ValidationContext(pessoa);

                bool ehValido = Validator.TryValidateObject(pessoa, contexto, resultadosValidacoes);

                if (!ehValido)
                {
                    if (resultadosValidacoes.Count > 0)
                    {
                        LblMSG.Text = string.Empty;

                        foreach (ValidationResult vr in resultadosValidacoes)
                        {
                            LblMSG.Text += $"{string.Format(vr.ErrorMessage, vr.MemberNames)}\n";
                        }
                    }
                }
                else 
                {
                    LblMSG.Text = "OK";
                    LblMSG.TextColor = Color.Green;
                }
            };

        }
    }
}
