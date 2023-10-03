using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailsId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string? Provider { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string? Status { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime CreatedAt { get; set; }

        //one-to-one
        public virtual OrderDetails? OrderDetails { get; set; }
    }
}
