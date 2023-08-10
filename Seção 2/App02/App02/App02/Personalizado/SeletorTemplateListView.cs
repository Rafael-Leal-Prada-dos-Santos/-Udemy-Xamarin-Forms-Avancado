using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static App02.MainPage;

namespace App02.Personalizado
{
    public class SeletorTemplateListView : DataTemplateSelector
    {
        public DataTemplate PessoaObrigatoria { get; set; }
        public DataTemplate PessoaNaoObrigatoria { get; set; }

        public SeletorTemplateListView()
        {
            PessoaNaoObrigatoria =
                new DataTemplate(typeof(Personalizado.Viewcell.PessoaNaoObrigatoriaViewCell));

            PessoaObrigatoria =
                new DataTemplate(typeof(Personalizado.Viewcell.PessoaObrigatorioViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Pessoa pessoa = item as Pessoa;

            if (pessoa.EhObrigatorio)
            {
                return PessoaObrigatoria;
            }
            else {
                return PessoaNaoObrigatoria;
            }
        }
    }
}
