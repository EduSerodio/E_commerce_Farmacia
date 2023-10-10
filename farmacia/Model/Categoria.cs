using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace farmacia.Model
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string Tipo { get; set; } = string.Empty;

        [InverseProperty("Categoria")]
        [JsonIgnore]
        public virtual ICollection<Produto>? Produto { get; set; }
    }
}