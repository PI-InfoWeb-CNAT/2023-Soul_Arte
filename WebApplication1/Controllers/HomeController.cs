using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        

        private EFContext context = new EFContext();

        // GET: Home
        public ActionResult Index()
        {
            Home h = new Home();
            h.produtos = context.Produtos.OrderBy(c => c.Nome);
            h.categorias = context.Categorias.OrderBy(c => c.Nome);
            h.clientes = context.Clientes.OrderBy(c => c.Nome);
            return View(h);

        }
        public ActionResult ViewPage()
        {
            return View();
        }
        public ActionResult Produto()
        {
            return View();
        }
        public ActionResult Login()
        {
            Cliente c = new Cliente
            {
                Nome = "Cliente Um",
                ClienteId = 1,
                Email = "cliente@email.com",
                Senha = "cliente123",
                User = "cliente2023"
            };
            return View();
        }
        public ActionResult LoginCliente(string email, string senha)
        {
            var data = context.Clientes.Where(s => s.Email.Equals(email) && s.Senha.Equals(senha)).ToList();
            if (data.Count() > 0)
            {
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                return RedirectToAction("Login");
            }
            return RedirectToAction("Index", "Cliente");
        }
    }
}