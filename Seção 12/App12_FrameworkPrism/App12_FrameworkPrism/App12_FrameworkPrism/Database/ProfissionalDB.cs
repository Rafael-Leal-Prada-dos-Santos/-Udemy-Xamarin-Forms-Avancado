using App12_FrameworkPrism_2.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace App12_FrameworkPrism_2.Database
{
    public class ProfissionalDB
    {
        public static List<Profissional> ObterListaProfissionais() 
        {
            return new List<Profissional>(Realm.GetInstance().All<Profissional>());
        }
    }
}
