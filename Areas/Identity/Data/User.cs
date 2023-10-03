using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DropShop.Models;

namespace DropShop.Areas.Identity.Data
{
    public class User : IdentityUser<int> // so that Id (primary key) is int
    {

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("First Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Last Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit reached")]
        public string? LastName { get; set; }


        [Column(TypeName = "datetime")]
        [Required]
        public DateTime CreatedAt { get; set; }

        // one-to-one
        public virtual Cart? Cart { get; set; }

        // one-to-one
        public virtual UserDetails? UserDetails { get; set; }

        // one-to-many
        public ICollection<UserPayment>? UserPaymentCollection { get; set; }

        // one-to-many
        public ICollection<OrderDetails>? OrderDetails { get; set; }
    }
}

