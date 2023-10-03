using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Discount Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? DiscountName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description")]
        [Required]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 character limit reached")]
        public string? DiscountDesc { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Amount(%)")]
        [Required]
        public int DiscountPrecent { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        public bool Active { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<Products>? ProductsCollection { get; set; }
    }
}
