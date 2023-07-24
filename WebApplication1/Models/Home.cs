using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Home
    {
        public IEnumerable<Produto> produtos;
        public IEnumerable<Categoria> categorias;
        public IEnumerable<Cliente> clientes;
    }
}