using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public string NomeLoja { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
        public int VendedorId { get; set; }
        public string CPF { get; set; }

        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}