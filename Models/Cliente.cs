using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        [Column("nome")]
        public string Nome {get; set;}

        [MaxLength(255)]
        [Required]
        [Column("endereco")]
        public string Endereco {get; set;}

      
        [Required]
        [Column("observacao",TypeName ="text")]
        public string Observacao {get; set;}
    }
}
