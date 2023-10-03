using DropShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DropShop.Models;

namespace DropShop.Data;

public class DropShopDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public DropShopDbContext(DbContextOptions<DropShopDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<User>? User { get; set; }
    public DbSet<UserDetails>? UserDetails { get; set; }
    public DbSet<UserPayment>? UserPayment { get; set; }
    public DbSet<Cart>? Cart { get; set; }
    public DbSet<CartItem>? CartItem { get; set; }
    public DbSet<OrderDetails>? OrderDetails { get; set; }
    public DbSet<PaymentDetails>? PaymentDetails { get; set; }
    public DbSet<OrderItem>? OrderItem { get; set; }
    public DbSet<Products>? Products { get; set; }
    public DbSet<Product>? Product { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<Discount>? Discount { get; set; }
}
