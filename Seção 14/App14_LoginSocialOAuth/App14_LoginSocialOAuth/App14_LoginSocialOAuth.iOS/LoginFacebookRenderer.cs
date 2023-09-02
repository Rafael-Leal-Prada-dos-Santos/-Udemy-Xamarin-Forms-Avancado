using App14_LoginSocialOAuth.iOS;
using App14_LoginSocialOAuth.Views;
using Foundation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginFacebook), typeof(LoginFacebookRenderer))]

namespace App14_LoginSocialOAuth.iOS
{
    public class LoginFacebookRenderer : PageRenderer
    {
        //No iOS para criar uma tela através do custom renderer naõ se inicializa
        //Através do construtor e sim da sobrecarga do metodo ViewDidAppear
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            var authenticator = new OAuth2Authenticator(
            clientId: "2955081421290240",
            scope: "",
            authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
            redirectUrl: new Uri("https://meudominio.com/auth/facebook/retorno"));

            authenticator.Completed += async (sender, args) =>
            {
                //Fazer a pagina atual desaparecer
                DismissViewController(true, null);

                var token = args.Account.Properties["access_token"].ToString();

                var requisicao = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, args.Account);
                var resposta = await requisicao.GetResponseAsync();

                //Como iOS não suporta Dynamic
                Newtonsoft.Json.Linq.JObject obj =
                Newtonsoft.Json.Linq.JObject.Parse(resposta.GetResponseText());


                string nome = obj["name"].ToString().Replace("\"", "");
                //string email = obj.email.ToString();

                App14_LoginSocialOAuth.App.NavegarParaInicial(nome);
            };

            //No iOS não se trabalha com activity, e sim com ViewController
            PresentViewController(authenticator.GetUI(), true, null);
        }
    }
}