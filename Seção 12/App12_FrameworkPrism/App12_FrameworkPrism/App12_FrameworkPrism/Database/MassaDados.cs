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

            //realm.Write(() => {
            //    realm.RemoveAll<Profissional>();
            //    realm.RemoveAll<Comentario>();
            //});

            int count = realm.All<Profissional>().Count();

            if (count == 0) 
            {
                realm.Write(() => {
                    for (int i = 0; i < 20; i++)
                    {
                        Profissional profissional = new Profissional() { Nome = $"Prof{i}", Descricao = $"Descricao{i}", Especialidade = $"Especialidade{i}", Imagem = "https://i.pinimg.com/originals/25/ef/a7/25efa79cb9e70f6af08cb47f851b8ebf.png" };

                        realm.Add<Profissional>(profissional);

                        for (int j = 0; j < 3; j++)
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
