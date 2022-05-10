using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{


    //HERANÇA - CRIANDO EQUIPE E QUE TENHA TODAS AS PROPRIEDADES DA EQUIPEBASE

    //NOME DA CLASSE : HERANÇA, INTERFACE

    //NECESSÁRIO CONFIGURAR AS FUNÇÕES SOLICITADAS NA INTERFACE
    public class Equipe : EquipeBase, IEquipe
    {

        public int idEquipe { get; set; }

        public string Nome { get; set; }

        public  string Imagem { get; set; }


        //VARIÁVEL DE DADOS

        private const string caminhobd = "Database/equipe.csv";

       
        //TODA VEZ QUE CRIAMOS UMA EQUIPE NOVA ELE ANALISA SE TEM UM BANCO DE DADOS CRIADO

        //MÉTODO CONSTRUTOR COM MESMO NOME DA CLASSE
        public Equipe()
        {

            
            //MÉTODO DA CLASSE DE HERANÇA DO EQUIPEBASE
            CriarPastaOuArquivo(caminhobd);
        }

        //CRIAR UMA FUNÇÃO QUE VAI RECEBER O OBJETO EQUIPE E VAI RETORNAR NO FORMATO CSV (STRING)

        //MÉTODO SOMENTE DA EQUIPE
        private string Preparar(Equipe e)
        {


            //return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;

            return $"{e.idEquipe}; {e.Nome}; {e.Imagem}";
        }




        //PROGRAMA CRIAR  AUTOMATICAMENTE SELECIONANDO A OPÇÃO DE IMPLEMENTAR A INTERFACE - SELECIONA O ERRO COM O MOUSE E APARECE A OPÇÃO DE IMPLEMENTAR
        public void Criar(Equipe novaEquipe)
        {

            string valor = Preparar(novaEquipe);

            //ARRAY DE STRINGS = NA POSIÇÃO 0 TEMOS O RETORNO DO "PREPARAR"
            string[] equipeTexto = { valor};


            //ARQUIVO VAMOS ADICIONAR UMA NOVA LINHA

            // CAMINHO DO ARQUIVO, STRING EM FORMATO ARRAY
            File.AppendAllLines(caminhobd, equipeTexto);
        }

        public List<Equipe> LerEquipes()
        {
            

            //LE TODAS AS EQUIPES CADASTRADAS E COLOCA TODOS OS OBJETOS NESTA LISTA
            List<Equipe> listaEquipes = new List<Equipe>();

            //LER TODAS AS LINHAS DO ARQUIVO CSV E ARMAZENAR EM UM ARRAY
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (var item in linhas)
            {
                //1;NOME DA EQUIPE;CAMINHO DA IMAGEM
                string[] linhaEquipe = item.Split(';');

                //CRIANDO O OBJETO EQUIPE
                Equipe equipeAtual = new Equipe();

                //BUSCANDO AS INFORMAÇÕES PARA CRIAR O OBJETO
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }




            return listaEquipes;
        }
    }
}
