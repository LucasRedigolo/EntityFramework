using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroEF.Models
{
    public class Produtos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProduto { get; set; }

        [Required(ErrorMessage="O Campo nome não pode ficar vazio")]
        [StringLength(50, MinimumLength=2)]
        public string NomeProduto { get; set; 
        
        [Required(ErrorMessage="O campo descrição não pode ficar vazio")]}
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
    }
}