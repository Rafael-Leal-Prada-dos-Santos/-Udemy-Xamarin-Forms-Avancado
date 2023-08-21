using App12_FrameworkPrism_2.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App12_FrameworkPrism_2.Database
{
    public class MassaDados
    {
        public static void CriarMassaDados() 
        {
            Realm realm = Realm.GetInstance();

            int count = realm.All<Profissional>().Count();

            if (count == 0) 
            {
                realm.Write(() => {
                    for (int i = 0; i < 20; i++)
                    {
                        Profissional profissional = new Profissional() { Nome = $"Prof{i}", Descricao = $"Descricao{i}", Especialidade = $"Especialidade{i}" };

                        realm.Add<Profissional>(profissional);

                        for (int j = 0; j < 3; i++)
                        {
                            Comentario comentario = new Comentario() { Profissional = profissional, Autor = $"Autor {i} {j}", Data = DateTimeOffset.Now, Descricao = $"Descrição {i} {j}" };

                            realm.Add<Comentario>(comentario);
                        }
                    }

                });
            }
        }
    }
}
