using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    [Table("produtos")]
    public class Produto
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
        [Column("imagem")]
        public string UrlImagem {get; set;}
        
        [Required]
        [Column("valor")]
        public double Valor {get; set;}
      
        [Column("descricao",TypeName ="text")]
        public string Descricao {get; set;}
    }
}
