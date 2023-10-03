using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DropShop.Areas.Identity.Data;

namespace DropShop.Models
{
    public class OrderDetails
    {
        [Key, ForeignKey("PaymentDetails")]
        public int OrderDetailsId { get; set; }

        public virtual PaymentDetails? PaymentDetails { get; set; }
        
        [ForeignKey("User")]
        public int? FK_User_OrderDetails { get; set; }
        public User? User { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Delivery Location")]
        [Required]
        [MaxLength(500, ErrorMessage = "Maximum 500 character limit reached")]
        public string? DeliveryLocation { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contact Number")]
        [Required]
        [MaxLength(50, ErrorMessage = "Maximum 50 character limit reached")]
        public string? ContactNumber { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 character limit reached")]
        public string? Comment { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CancelledAt { get; set; }

        public  ICollection<OrderItem>? OrderItemCollection { get; set; }
    }
}
