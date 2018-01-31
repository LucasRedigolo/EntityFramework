using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroEF.Models {
    public class Pedidos {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int IDPedido { get; set; }

        [Required]
        public int IDCliente { get; set; }

        [Required]
        public int IDProduto { get; set; }
        
        
        [Required]
        public int Quantidade { get; set; }

        public Produtos Produtos { get; set; }
        public Clientes Clientes { get; set; }
    }
}