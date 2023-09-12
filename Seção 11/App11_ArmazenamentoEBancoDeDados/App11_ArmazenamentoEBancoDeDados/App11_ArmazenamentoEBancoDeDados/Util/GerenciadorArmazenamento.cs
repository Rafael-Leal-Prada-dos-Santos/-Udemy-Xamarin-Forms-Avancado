using PCLStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App11_ArmazenamentoEBancoDeDados.Util
{
    public class GerenciadorArmazenamento
    {
        public static async void SalvarArquivo(string arquivo, string conteudo) 
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFolder folder = await rootFolder.CreateFolderAsync("Arquivos",
                CreationCollisionOption.OpenIfExists);

            IFile file = await folder.CreateFileAsync(arquivo,
                CreationCollisionOption.ReplaceExisting);

            await file.WriteAllTextAsync(conteudo);
        }

        public static async Task<string> LerArquivo(string nomeArquivo)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFolder pasta = await rootFolder.CreateFolderAsync("Arquivos",
                CreationCollisionOption.OpenIfExists);

            IFile arquivoEncontrado = await pasta.GetFileAsync(nomeArquivo);

            return await arquivoEncontrado.ReadAllTextAsync();
        }
    }
}
