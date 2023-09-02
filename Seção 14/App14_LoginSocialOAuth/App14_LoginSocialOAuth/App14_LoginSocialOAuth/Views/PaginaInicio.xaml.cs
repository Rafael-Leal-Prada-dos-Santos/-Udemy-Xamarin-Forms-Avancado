using Xamarin.Forms;

namespace App14_LoginSocialOAuth.Views
{
    public partial class PaginaInicio : ContentPage
    {
        public PaginaInicio(params string[] parametros)
        {
            InitializeComponent();

            foreach (string parametro in parametros) 
            {
                lblInformacao.Text += $"{parametro} \n";
            }
        }
    }
}
