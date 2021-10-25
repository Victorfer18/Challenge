using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Models
{
    [Table("Tbl_Produto")]
    public class Produto
    {
        [Column("Id"), HiddenInput]
        public int ProdutoId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Column("Pc_preco"), Required]
        public decimal Preco { get; set; }
        
        [Column("Corredor"), MaxLength(55)]
        public string Corredor { get; set; }
        
        [Column("Qt_quantidade"), Required]
        public int Quantidade { get; set; }

        [Column("Dt_validade"), Required, Display(Name = "Data Validade"), DataType(DataType.Date)]
        public DateTime DataValidade { get; set; }

        [Display(Name ="Categoria")]
        public Categoria? Categoria { get; set; }


        
    }
    public enum Categoria
        {
            Alimentos_Bebidas, Higiene, Limpeza
        }
}
