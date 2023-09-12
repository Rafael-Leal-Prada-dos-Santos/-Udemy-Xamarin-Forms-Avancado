using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace App12_FrameworkPrism_2.Models
{
    public class Comentario: RealmObject
    {
        public Profissional Profissional { get; set; }
        public string Autor { get; set; }
        public DateTimeOffset Data { get; set; }
        public string Descricao { get; set; }
    }
}
