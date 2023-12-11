using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VendedorController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Vendedor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar_produto()
        {
            return View();
        }
        private byte[] SetLogotipo(HttpPostedFileBase logotipo)
        {
            var bytesLogotipo = new byte[logotipo.ContentLength];
            logotipo.InputStream.Read(bytesLogotipo, 0, logotipo.ContentLength);
            return bytesLogotipo;
        }
        [HttpPost] // Adicione o atributo [HttpPost] para indicar que este método responde a solicitações POST
        public ActionResult Adicionar_produto(Produto produto, HttpPostedFileBase ImagemArquivo)
        {
            if (ModelState.IsValid)
            {
                Produto novoProduto = new Produto();
                novoProduto.Nome = produto.Nome;
                novoProduto.Preco = produto.Preco;
                novoProduto.Estoque = produto.Estoque;
                novoProduto.Descricao = produto.Descricao;
                novoProduto.Imagem = SetLogotipo(ImagemArquivo);

                // Verifique se a imagem foi enviada e tem dados
                


                // Adicione o novo produto ao contexto do Entity Framework
               context.Produtos.Add(novoProduto);

                // Salve as alterações no banco de dados
                context.SaveChanges();

                return View();
            }

            // Se o modelo não for válido, retorne para a página de adicionar produto com mensagens de erro, falta ajeitar
            return View();
        }
    }
}
