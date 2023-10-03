using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int FK_Category_Products { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("Discount")]
        public int? FK_Discount_Products { get; set; } // we need the "?" so that it is nullable Int
        public Discount? Discount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Product Name")]
        [Required]
        public string? ProductName { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Image Source")]
        [Required]
        public string? ImgSrc { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Product Details")]
        [Required]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 character limit reached")]
        public string? ProductDetails { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string? Brand { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Price { get; set; }

        [Column(TypeName = "int")]
        public int? Sales { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        public bool Featured { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string? Sex { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime DateAdded { get; set; }

        public ICollection<Product>? ProductCollection { get; set; }

        public ICollection<CartItem>? CartItemCollection { get; set; }

        public ICollection<OrderItem>? OrderItemCollection { get; set; }
    }
}
