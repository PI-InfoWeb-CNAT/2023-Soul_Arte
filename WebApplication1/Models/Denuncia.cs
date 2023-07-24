using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Denuncia
    {
        public int DenunciaId { get; set; }
        public string Conteudo { get; set; }
        public bool Razao1 { get; set; }
        public bool Razao2 { get; set; }
        public bool Razao3 { get; set; }
        public bool Razao4 { get; set; }
        public bool Razao5 { get; set; }
        public bool Razao6 { get; set; }

    }
}