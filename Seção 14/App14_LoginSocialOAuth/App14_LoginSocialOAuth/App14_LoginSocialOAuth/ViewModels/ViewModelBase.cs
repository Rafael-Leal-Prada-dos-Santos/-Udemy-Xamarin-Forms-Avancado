using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace App14_LoginSocialOAuth.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        private string _titulo;
        public string Titulo 
        {
            get => _titulo;
            set => SetProperty(ref _titulo, value);
        }

        public ViewModelBase() 
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
