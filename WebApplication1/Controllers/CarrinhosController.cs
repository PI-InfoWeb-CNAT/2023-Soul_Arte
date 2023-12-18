using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarrinhosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Carrinhos
        public ActionResult Index()
        {
            IEnumerable<ItemCarrinho> carrinho =

        HttpContext.Session["carrinho"] as IEnumerable<ItemCarrinho>;

            if (carrinho == null)
            {
                carrinho = new List<ItemCarrinho>();
                HttpContext.Session["carrinho"] = carrinho;

            }
            return View(carrinho);
        }
        public ActionResult AddProduto(FormCollection collection)
        {
            List<ItemCarrinho> carrinho = HttpContext.Session["carrinho"] as
            List<ItemCarrinho>;
            var produto2 = ObterProdutoPorId(
            Convert.ToInt32(collection.Get("ItemCarrinhoId")));
            //var qtd = Convert.ToInt32(collection.Get("Quantidade"));
            var itemCarrinho = new ItemCarrinho()
            {
                Produto = produto2,
                Quantidade = 1,
                ValorUnitario = 1
            };
            carrinho.Add(itemCarrinho);
            HttpContext.Session["carrinho"] = carrinho;
            return RedirectToAction("Index");
        }
        private Produto ObterProdutoPorId(long id)
        {
            var produto = context.Produto.Find(id);
            return produto;
        }
    }
}