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
        public ActionResult Produto()
        {
            return View();
        }
        public ActionResult Login()
        {
            Cliente c = new Cliente
            {
                User = "cliente2023",
                Nome = "Cliente Um",
                ClienteId = 1,
                Email = "cliente@email.com",
                Senha = "cliente123",
                DataNascimento = "15/09/2005"
            };
            if (context.Clientes.Where(p => p.ClienteId == 1).Count() == 0)
            {
                context.Clientes.Add(c);
                context.SaveChanges();

            }

            return View();
        }
        /*[HttpPost]
        public ActionResult Login(string email, string senha)
        {
            if (ModelState.IsValid)
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
            }
            return View();
        }*/
        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            // Verifica se os campos de email e senha foram preenchidos
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                // Adicione uma mensagem de erro à ViewData
                ViewData["ErrorMessage"] = "Preencha todos os campos.";

                // Retorna para a View de login, exibindo a mensagem de erro
                return View("Login");
            }

            var data = context.Clientes.Where(s => s.Email.Equals(email) && s.Senha.Equals(senha)).ToList();
            if (data.Count() > 0)
            {
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                // Caso os dados de login estejam incorretos, adicione uma mensagem de erro à ViewData
                ViewData["ErrorMessage"] = "Email ou senha incorretos.";

                // Retorna para a View de login, exibindo a mensagem de erro
                return View("Login");
            }
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult SignInCliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignInCliente(string nome, string email, string CPF, string data, int telefone, string senha)
        {
            Cliente c = new Cliente()
            {
                Nome = nome,
                Email = email,
                CPF = CPF,
                DataNascimento = data,
                Telefone = telefone,
                Senha = senha
            };
            context.Clientes.Add(c);
            context.SaveChanges();
            return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult Denunciar(Denuncia denuncia)
        {

            if (ModelState.IsValid)
            {
                context.Denuncias.Add(denuncia);
                context.SaveChanges();
                return RedirectToAction("Produto");
            }
            return View();
        }

    }
}