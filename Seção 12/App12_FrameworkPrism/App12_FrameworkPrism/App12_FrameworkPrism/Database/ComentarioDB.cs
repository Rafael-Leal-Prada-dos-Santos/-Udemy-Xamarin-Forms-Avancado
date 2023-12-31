﻿using App12_FrameworkPrism_2.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App12_FrameworkPrism_2.Database
{
    public class ComentarioDB
    {
        public static List<Comentario> ObterListaComentarios(Profissional profissional)
        {
            return new List<Comentario>(Realm.GetInstance().All<Comentario>().Where(a => a.Profissional == profissional));
        }
    }
}
