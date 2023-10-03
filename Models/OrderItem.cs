using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        [ForeignKey("Products")]
        public int FK_Products_OrderItem { get; set; }
        public Products? Products { get; set; }

        [Required]
        [ForeignKey("OrderDetails")]
        public int FK_OrderDetails_OrderItem { get; set; }
        public OrderDetails? OrderDetails { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Quantity")]
        [Required]
        public int QTY { get; set; }
    }
}
