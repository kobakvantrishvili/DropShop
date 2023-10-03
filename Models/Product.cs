using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("Products")]
        public int FK_Products_Product { get; set; }
        public Products? Products { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? SKU { get; set; }

        [Column(TypeName = "char(13)")]
        [Required]
        [MaxLength(13, ErrorMessage = "Maximum 13 character limit reached")]
        public string? UPC { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Required]
        public string? Size { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50, ErrorMessage = "Maximum 50 character limit reached")]
        public string? Fit { get; set; }

        [Column(TypeName = "int")]
        public int? Sales { get; set; }

        [Column(TypeName = "int")]
        public int Amount { get; set; }
    }
}
