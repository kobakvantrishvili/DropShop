using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropShop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Category Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? CategoryName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        [DisplayName("Description")]
        [Required]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 character limit reached")]
        public string? CategoryDesc { get; set; }

        [Column(TypeName = "datetime")]
        [Required]
        public DateTime CreatedAt { get; set; }

        public ICollection<Products>? ProductsCollection { get; set; }
    }
}
