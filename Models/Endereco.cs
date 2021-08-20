using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    [Table("enderecos")]
    public class Endereco
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        
        [MaxLength(255)]
        [Required]
        [Column("logradouro")]
        public string Logradouro {get; set;}

        [MaxLength(30)]
        [Required]
        [Column("numero")]
        public string Numero {get; set;}

        [MaxLength(10)]
        [Required]
        [Column("cep")]
        public string Cep {get; set;}

        [MaxLength(150)]
        [Required]
        [Column("bairro")]
        public string Bairro {get; set;}

        [MaxLength(255)]
        [Required]
        [Column("complemento")]
        public string Complemento {get; set;}

        [MaxLength(150)]
        [Required]
        [Column("cidade")]
        public string Cidade {get; set;}

        [MaxLength(2)]
        [Required]
        [Column("estado")]
        public string Estado {get; set;}

   
    }
}
