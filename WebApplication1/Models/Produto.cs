using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public byte[] Imagem { get; set; }
        public string LogotipoMimeType { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }

    }
}