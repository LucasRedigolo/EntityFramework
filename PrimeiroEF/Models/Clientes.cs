using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroEF.Models
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCliente { get; set; }

        [Required]
        [StringLength(100, MinimumLength=2, ErrorMessage="Você deve inserir um nome que contenha de 2 a 100 caracteres!")]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [Range(1,100)]
        public int Idade { get; set; }

        public ICollection<Pedidos> Pedidos { get; set; }
        
    }
}