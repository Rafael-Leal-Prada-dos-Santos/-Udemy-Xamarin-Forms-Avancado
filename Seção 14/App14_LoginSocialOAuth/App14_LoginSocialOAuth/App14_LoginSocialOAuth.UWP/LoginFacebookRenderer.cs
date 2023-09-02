using App14_LoginSocialOAuth.UWP;
using App14_LoginSocialOAuth.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(LoginFacebook), typeof(LoginFacebookRenderer))]
namespace App14_LoginSocialOAuth.UWP
{
    public class LoginFacebookRenderer : PageRenderer
    {
        public LoginFacebookRenderer() 
        {
            var authenticator = new OAuth2Authenticator(
            clientId: "2955081421290240",
            scope: "",
            authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
            redirectUrl: new Uri("https://meudominio.com/auth/facebook/retorno"));

            authenticator.Completed += async(sender, args) => 
            {
                var token = args.Account.Properties["access_token"].ToString();

                var requisicao = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, args.Account);
                var resposta = await requisicao.GetResponseAsync();

                dynamic obj = JsonConvert.DeserializeObject(resposta.GetResponseText());

                string nome = obj.name.ToString();
                //string email = obj.email.ToString();

                App14_LoginSocialOAuth.App.NavegarParaInicial(nome);
            };


            Windows.UI.Xaml.Controls.Frame rootFrame =
                Windows.UI.Xaml.Window.Current.Content as Windows.UI.Xaml.Controls.Frame;

            rootFrame.Navigate(authenticator.GetUI());

            //var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            //presenter.Login(authenticator);

        }
    }
}
