using App12_FrameworkPrism.Views;
using App12_FrameworkPrism_2.Database;
using App12_FrameworkPrism_2.Models;
using App12_FrameworkPrism_2.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App12_FrameworkPrism.ViewModels
{
    public class ListaProfissionaisViewModel : ViewModelBase
    {
        private List<Profissional> _listaProf;

        public List<Profissional> ListaProf 
        {
            get => _listaProf;
            set => SetProperty(ref _listaProf, value);
        }

        public DelegateCommand<Profissional> ProfissionalTocado { get; set; }

        public ListaProfissionaisViewModel(INavigationService navigationService):
            base(navigationService)
        {
            ListaProf = ProfissionalDB.ObterListaProfissionais();

            ProfissionalTocado = new DelegateCommand<Profissional>(ProfisionalSelecionado);
        }

        private void ProfisionalSelecionado(Profissional profissional)
        {
            NavigationParameters parametros = new NavigationParameters();
            parametros.Add("profissional", profissional);

            NavigationService.NavigateAsync($"NavigationPage/{nameof(DetalheProfissional)}", parametros);
        }
    }
}
