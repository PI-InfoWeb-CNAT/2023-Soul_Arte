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
        public int CPF { get; set; }
        public int DataNascimento { get; set; }
        public int Telefone { get; set; }
    }
}