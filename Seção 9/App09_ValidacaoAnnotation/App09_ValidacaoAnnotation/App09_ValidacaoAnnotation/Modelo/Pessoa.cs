using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App09_ValidacaoAnnotation.Modelo
{
    public class Pessoa
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O Campo nome é obrigatório")]
        [StringLength(60, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E01", ErrorMessageResourceType = typeof(Lingua.Mensagem))]
        [EmailAddress(ErrorMessage = null, ErrorMessageResourceName = "MSG_E02", ErrorMessageResourceType = typeof(Lingua.Mensagem))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E01", ErrorMessageResourceType = typeof(Lingua.Mensagem))]
        [CPF(ErrorMessageResourceName ="MSG_E02", ErrorMessageResourceType = typeof(Lingua.Mensagem))]
        public string CPF { get; set; }
    }

}
