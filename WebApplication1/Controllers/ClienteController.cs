using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }
        public ActionResult Redefinir_senha()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Redefinir_senha(string senha, string confirmacao)
        {
            if (senha == confirmacao)
            {

                string cliente = Session["Cliente"].ToString();
                Cliente data = context.Clientes.Where(s => s.Email.Equals(cliente)).First();
                data.Senha = senha;
                context.Entry(data).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Perfil");
            }
            else
            {
                ViewData["ErrorMessage"] = "Senhas não correspondem";
                return View("Redefinir_senha");
            }
        }
        [HttpPost]
        public ActionResult AlterarDados(string user, string nome, string cpf, string datanascimento, string email)
        {
            string cliente = Session["Cliente"].ToString();
            Cliente data = context.Clientes.Where(s => s.Email.Equals(cliente)).First();
            if (user != "") data.User = user;
            if (nome != "") data.Nome = nome;
            if (cpf != "") data.CPF = user;
            if (datanascimento != "") data.DataNascimento = datanascimento;
            if (email != "")
            {
                var loc = context.Clientes.Where(s => s.Email.Equals(email)).ToList();
                if (loc.Count() == 0) data.Email = email;
                else
                {
                    ViewData["ErrorMessage"] = "Email já cadastrado";
                }
            }
            context.Entry(data).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            ViewData["OkMessage"] = "Dados Atualizados";
            return View("Perfil");
        }
        public ActionResult Logout()
        {
            Session["Cliente"] = "";
            return RedirectToAction("Index", "Home");
        }
    }
}