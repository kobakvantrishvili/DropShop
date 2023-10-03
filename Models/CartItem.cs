using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class CartItem
    {   
        [Key]
        public int CartItemId { get; set; }

        [Required]
        [ForeignKey("Cart")]
        public int FK_Cart_CartItem { get; set; }
        public Cart? Cart { get; set; }

        [ForeignKey("Products")]
        public int? FK_Products_CartItem { get; set; }
        public Products? Products { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Quantity")]
        [Required]
        public int QTY { get; set; }
    }
}
