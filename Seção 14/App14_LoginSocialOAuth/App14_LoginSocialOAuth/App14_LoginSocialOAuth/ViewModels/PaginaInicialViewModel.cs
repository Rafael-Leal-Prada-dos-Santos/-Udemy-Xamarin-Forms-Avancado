using App14_LoginSocialOAuth.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App14_LoginSocialOAuth.ViewModels
{
    public class PaginaInicialViewModel : ViewModelBase
    {
        public DelegateCommand ComandoLogarNoFacebook { get; set; }

        public PaginaInicialViewModel()
        {
            ComandoLogarNoFacebook = new DelegateCommand(LogarNoFacebook);
        }

        private void LogarNoFacebook()
        {
            App.Current.MainPage = new LoginFacebook();
        }
    }
}
