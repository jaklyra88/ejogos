using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {

        //CONTRATO
        //REPRESENTA OS MÉTODOS QUE SÃO OBRIGATÓRIOS EM UMA CLASSE

        //RECEBE UMA VARIÁVEL DO TIPO EQUIPE (OBJETO EQUIPE)
        void Criar(Equipe novaEquipe);

        List<Equipe>LerEquipes();



    }
}
