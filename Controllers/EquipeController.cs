using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{

    //ACTIONRESULT REPRESENTAM OS VARIOS CODIGOS HTTP

    //CÓDIGOS DE ERRO HTTP
    public class EquipeController : Controller
    {
        //RESPONSÁVEL POR RECEBER AS REQUISIÇÕES

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {
            //VIEWBAG = RESERVA DE ESPAÇO PARA ARMAZENAR INFORMAÇÕES PARA RECUPERAR NA VIEW.
            //TEM A FUNÇÃO DE CARREGAR AS INFORMAÇÕES DE CONTROLLER PARA A VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
