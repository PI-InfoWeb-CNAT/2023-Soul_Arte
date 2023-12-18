using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Vendedor h = new Vendedor();
            h.produtos = context.Produto.OrderBy(c => c.Nome);
            return View(h);
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
        public FileContentResult GetLogotipo(long id)
        {
            Produto produto = ObterProdutoPorId(id);
            if (produto != null)
            {
                if (produto.NomeArquivo != null)
                {
                    string filePath = Path.Combine(Server.MapPath("~/Uploads/"), produto.NomeArquivo);

                    // Lógica para recuperar os bytes da imagem usando o caminho do arquivo
                    byte[] imageBytes = System.IO.File.ReadAllBytes(filePath);

                    // Determine o tipo de conteúdo da imagem (por exemplo, image/jpeg)
                    string contentType = MimeMapping.GetMimeMapping(filePath);

                    // Retorne a imagem como FileContentResult
                    return new FileContentResult(imageBytes, contentType);
                }
            }

            return null;
        }
        private Produto ObterProdutoPorId(long id)
        {
            var produto = context.Produto.Find(id);
            return produto;
        }
        [HttpPost] // Adicione o atributo [HttpPost] para indicar que este método responde a solicitações POST
        public ActionResult Adicionar_produto(Produto produto, HttpPostedFileBase ImagemArquivo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto novoProduto = new Produto();
                    novoProduto.Nome = produto.Nome;
                    novoProduto.Preco = produto.Preco;
                    novoProduto.Estoque = produto.Estoque;
                    novoProduto.Descricao = produto.Descricao;
                    novoProduto.Imagem = SetLogotipo(ImagemArquivo);
                    produto.LogotipoMimeType = ImagemArquivo.ContentType;
                    produto.TamanhoArquivo = ImagemArquivo.ContentLength;

                    context.Produto.Add(novoProduto);
                    context.SaveChanges();

                    // Adicione mensagens de sucesso usando TempData
                    TempData["SuccessMessage"] = "Produto adicionado com sucesso!";
                    string strFileName = Server.MapPath("~/Uploads/") + Path.GetFileName(ImagemArquivo.FileName);
                    ImagemArquivo.SaveAs(strFileName);
                }
                catch (Exception ex)
                {
                    // Adicione mensagens de erro usando TempData
                    TempData["ErrorMessage"] = $"Erro ao adicionar o produto: {ex.Message}";
                }

                return RedirectToAction("Adicionar_produto");
            }
            else
            {
                TempData["ErrorMessage"] = $"Erro ao adicionar o produto";

            }

            // Se o modelo não for válido, retorne para a página de adicionar produto com mensagens de erro
            return View();
        }

    }
}
