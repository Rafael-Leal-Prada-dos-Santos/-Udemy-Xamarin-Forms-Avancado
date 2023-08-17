using App09_ValidacaoAnnotation.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace System.ComponentModel.DataAnnotations
{
    public class CPFAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cpf = value as string;

            if (CPF.IsCpf(cpf))
            {
                return ValidationResult.Success;
            }
            else 
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
