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
    public class DetalheProfissionalViewModel : ViewModelBase
    {

        private Profissional _profissional;

        public Profissional Profissional
        {
            get => _profissional;
            set => SetProperty(ref _profissional, value);
        }

        private List<Comentario> _comentarios;

        public List<Comentario> Comentarios
        {
            get => _comentarios;
            set => SetProperty(ref _comentarios, value);
        }
        public DetalheProfissionalViewModel(INavigationService navigationService):
            base(navigationService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("profissional"))
            {
                Profissional = parameters.GetValue<Profissional>("profissional");
                Comentarios = ComentarioDB.ObterListaComentarios(Profissional);
            }
        }
       
    }
}
