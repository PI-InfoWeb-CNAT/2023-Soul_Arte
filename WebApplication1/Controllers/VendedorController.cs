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

        [HttpPost] // Adicione o atributo [HttpPost] para indicar que este método responde a solicitações POST
        public ActionResult Adicionar_produto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var novoProduto = new Produto
                {
                    Nome = produto.Nome,
                    Preco = produto.Preco,
                    Estoque = produto.Estoque,
                    Descricao = produto.Descricao
                    // Mapeie outras propriedades conforme necessário
                };

                // Verifique se a imagem foi enviada e tem dados
                if (produto.ImagemArquivo != null && produto.ImagemArquivo.ContentLength > 0)
                {
                    // Converta a imagem para um array de bytes
                    using (BinaryReader reader = new BinaryReader(produto.ImagemArquivo.InputStream))
                    {
                        novoProduto.Imagem = reader.ReadBytes(produto.ImagemArquivo.ContentLength);
                    }
                }


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
