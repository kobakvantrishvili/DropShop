using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Areas.Identity.Data
{
    public class UserDetails
    {
        [Key, ForeignKey("User")]
        public int UserDetailsId { get; set; }

        public virtual User? User { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? Country { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? City { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Postal Code")]
        [Required]
        [MaxLength(10, ErrorMessage = "Maximum 10 character limit reached")]
        public string? PostalCode { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Address Line 1")]
        [Required]
        [MaxLength(500, ErrorMessage = "Maximum 500 character limit reached")]
        public string? AddressLine1 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Address Line 2")]
        [MaxLength(500, ErrorMessage = "Maximum 500 character limit reached")]
        public string? AddressLine2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Phone Number")]
        [MaxLength(50, ErrorMessage = "Maximum 50 character limit reached")]
        public string? Mobile { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime ModifiedAt { get; set; }
    }
}
