using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebLoja.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext() : base("WebLoja")
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}