using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DropShop.Areas.Identity.Data;

namespace DropShop.Models
{
    public class Cart
    {
        [Key, ForeignKey("User")]
        public int CartId { get; set; }

        public virtual User? User { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Total { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<CartItem>? CartItemCollection { get; set; }

    }
}
