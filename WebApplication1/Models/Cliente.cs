using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
        public int ClienteId { get; set; }
        public string CPF { get; set; }
      
        public string DataNascimento { get; set; }
        public int Telefone { get; set; }
    }
}