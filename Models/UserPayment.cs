using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DropShop.Areas.Identity.Data;

namespace DropShop.Models
{
    public class UserPayment
    {
        [Key]
        public int UserPaymentId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int FK_User_UserPayment { get; set; }
        public User? User { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Payment Type")]
        [Required]
        public string? PaymentType { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Provider")]
        [Required]
        public string? Provider { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Account No.")]
        [Required]
        public int AccountNo { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime ExpieryDate { get; set; }
    }
}
