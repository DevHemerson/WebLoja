using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLoja.Models
{
    public class Produto
    {
        [ScaffoldColumn(false)]
        public int ProdutoID { get; set; }

        [Required, StringLength(100), Display(Name = "Nome")]
        public string NomeProduto { get; set; }

        [Required, StringLength(10000), Display(Name = "Descricao"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Preco")]
        public double? PrecoUnidade { get; set; }

        public int? CategoriaID { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}