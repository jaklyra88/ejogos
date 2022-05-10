using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {

        public void CriarPastaOuArquivo(string caminho)
        {

            //NOME DE UMA PASTA / NOMEDOARQUIVO.CSV

            //GUARDANDO VAÁRIAVEL APENAS COM O NOME DA PASTA

            //ABRIR O CAMINHO INICIAR A PARTIR DA POSIÇÃO 0

            //SPLITE DETERMINADOS DE QUE FORMA AS INFORMAÇÕES SERÃO DIVIDIDAS ( NA EXIBIÇÃO)
            string pasta = caminho.Split('/')[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(caminho);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }

           


        }


    }
}
