using App12_FrameworkPrism_2.Database;
using App12_FrameworkPrism_2.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App12_FrameworkPrism.ViewModels
{
    public class ListaProfissionaisViewModel : BindableBase
    {
        private List<Profissional> _listaProf;

        public List<Profissional> ListaProf 
        {
            get => _listaProf;
            set => SetProperty(ref _listaProf, value);
        }

        public ListaProfissionaisViewModel()
        {
            ListaProf = ProfissionalDB.ObterListaProfissionais();
        }
    }
}
