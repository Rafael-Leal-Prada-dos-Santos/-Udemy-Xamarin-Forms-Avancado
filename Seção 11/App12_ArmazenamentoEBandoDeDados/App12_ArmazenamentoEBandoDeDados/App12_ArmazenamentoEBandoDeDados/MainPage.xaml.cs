using App12_ArmazenamentoEBandoDeDados.Modelo;
using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App12_ArmazenamentoEBandoDeDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Realm realm = Realm.GetInstance();

            Lista.ItemsSource = realm.All<Produto>();
        }

        private void BtnAdicionar_Clicked(object sender, EventArgs e)
        {

            Produto produto = new Produto()
            {
                Item = Item.Text,
                Quantidade = int.Parse(Quantidade.Text)
            };

            List<ValidationResult> resultadosValidacao = new List<ValidationResult>();

            ValidationContext contextoValidacao = new ValidationContext(produto);

            bool valido =Validator.TryValidateObject(produto, contextoValidacao, resultadosValidacao, true);
            if (valido == false) 
            {
                string mensagem = string.Empty;

                foreach (ValidationResult resultadoValidacao in resultadosValidacao) 
                {
                    mensagem += resultadoValidacao.ErrorMessage + "\n";
                }

                DisplayAlert("Erros", mensagem, "Ok");

                return;
            }

            //Salvar
            Realm realm = Realm.GetInstance();

            Produto ultimoProdutoCadastrado = realm.All<Produto>().OrderByDescending(p => p.Id).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(ID.Text))
            {
                #region Produto - Atualizar
                produto.Id = int.Parse(ID.Text);

                realm.Write(() =>
                {
                    realm.Add(produto, true);
                });
                #endregion
            }
            else 
            {
                #region Produto - Adicionar
                int novoId = 0;
                if (ultimoProdutoCadastrado != null)
                {
                    novoId = ultimoProdutoCadastrado.Id + 1;
                }

                produto.Id = novoId;

                realm.Write(() =>
                {
                    realm.Add(produto);
                });

                #endregion
            }

            ID.Text = string.Empty;
            Item.Text = string.Empty;
            Quantidade.Text = string.Empty;


            Lista.ItemsSource = realm.All<Produto>();
            DisplayAlert("Sucesso", $"Itens do banco de dados : {realm.All<Produto>().Count()}", "Ok");
      
        }

        private void Excluir_Clidado(object sender, EventArgs e)
        {
            MenuItem item = sender as MenuItem;

            Produto produto = item.CommandParameter as Produto;

            Realm realm = Realm.GetInstance();

            realm.Write(() =>
            {
                realm.Remove(produto);
            });

            Lista.ItemsSource = realm.All<Produto>();
        }

        private void Atualizar_Clidado(object sender, EventArgs e)
        {
            MenuItem item = sender as MenuItem;

            Produto produto = item.CommandParameter as Produto;

            ID.Text = produto.Id.ToString();
            item.Text = produto.Item;
            Quantidade.Text = produto.Quantidade.ToString();

            
        }
    }
}
