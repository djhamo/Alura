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
    public class ProdutoController : Controller
    {
        [Route("produtos", Name ="ListaProdutos")]
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();

            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View(produtos);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Form()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();

            ViewBag.Produto = new Produto();
            ViewBag.Categorias = categorias;

            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int idInformatica = 1;
            if (produto.CategoriaId.Equals(idInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.Invalido", "Informática com preço abaixo de R$ 100,00");
            }
            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);

                return RedirectToAction("Index", "Produto");

            }
            else
            {
                ViewBag.Produto = produto;
                CategoriasDAO dao = new CategoriasDAO();
                IList<CategoriaDoProduto> categorias = dao.Lista();

                ViewBag.Categorias = categorias;
                return View("Form");

            }
        }

        [Route("produtos/{id}", Name ="VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            ViewBag.Produto = produto;
            return View(produto);
        }

        
        public ActionResult DecrementaQtd(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade--;
            dao.Atualiza(produto);
            return Json(produto);
        }
    }

}