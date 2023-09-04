

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Newtonsoft.Json;
using Xamarin.Auth;

using App14_LoginSocialOAuth.Droid;
using App14_LoginSocialOAuth.Views;

[assembly: ExportRenderer(typeof(LoginFacebook), typeof(LoginFacebookRenderer))]
namespace App14_LoginSocialOAuth.Droid
{
    public class LoginFacebookRenderer : PageRenderer
    {
        public LoginFacebookRenderer(Context context) : base(context)
        {
            var autenticacao =
                new OAuth2Authenticator(
                    clientId: "2955081421290240",
                    scope: "",
                    authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                    redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html")
                );

            autenticacao.Completed += async (sender, args) =>
            {
                if (args.IsAuthenticated)
                {
                    //Token de Acesso

                    var token = args.Account.Properties["access_token"].ToString();

                    var requisicao = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, args.Account);
                    var resposta = await requisicao.GetResponseAsync();

                    dynamic obj = JsonConvert.DeserializeObject(resposta.GetResponseText());

                    string nome = obj.name.ToString();
                    //string email = obj.email.ToString();

                    App.NavegarParaInicial(nome);
                }
                else 
                {

                    App.NavegarParaInicial("Login Rejeitado!");
                }
            };


            var activity = this.Context as Activity;

            activity.StartActivity(autenticacao.GetUI(activity));
        }
    }
}