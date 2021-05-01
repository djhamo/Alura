using CaelumEstoque.DAO;
using CaelumEstoque.Filtros;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    [AutorizacaoFilterAttribute]
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> lista = dao.Lista();

            ViewBag.Categorias = lista;

            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);

            return RedirectToAction("Index", "Categoria");
        }
    }
}