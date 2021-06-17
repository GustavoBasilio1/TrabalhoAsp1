using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtividadeAsp1.Models;



namespace AtividadeAsp1.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult Index()
        {
            var produtos = new Produtos(); //Criando o objeto para classe
            return View(produtos); //Retornando para a view os dados da classe
        }
        [HttpPost]
        //Criar uma nova index, clicar com o botão direto do mouse
        //AddView manter o nome index e substituir



        public ActionResult Index(Produtos produtos)
        {
            if (ModelState.IsValid)//Validando o estado, ou seja, verificando a requisição
            {
                return View("Result", produtos); //Retorna para a view resultado
            }
            return View(produtos);
        }



        public ActionResult Result(Produtos produtos) //Criando a ação para a view resultado
        {
            return Result(produtos);
        }




        public ActionResult LoginUnico(string codigo)
        {
            var bdProdutos = new Collection<string>
            {
            "4",
            "9"
            };
            return Json(bdProdutos.All(x => x.ToLower() != codigo.ToLower()), JsonRequestBehavior.AllowGet);
        }



    }
}