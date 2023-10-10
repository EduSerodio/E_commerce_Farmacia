using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace farmacia.Model
{
    public class Produto
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;

        [Column(TypeName = "decimal")]
        [Precision(20,2)]
        public decimal Preco { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}