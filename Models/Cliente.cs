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
      
        [Required]
        [Column("observacao",TypeName ="text")]
        public string Observacao {get; set;}

        [Column("endereco_id")]
        public int EnderecoId {get; set;}

        [ForeignKey("EnderecoId")]
        public Endereco Endereco {get; set;}
    }
}
