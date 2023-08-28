using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App14_LoginSocialOAuth.ViewModels
{
    public class PaginaInicialViewModel : BindableBase
    {
        private string _title;
        public string Title 
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public DelegateCommand ComandoLogarNoFacebook { get; set; }

        public PaginaInicialViewModel()
        {
            ComandoLogarNoFacebook = new DelegateCommand(LogarNoFacebook);
        }

        private void LogarNoFacebook()
        {
            throw new NotImplementedException();
        }
    }
}
