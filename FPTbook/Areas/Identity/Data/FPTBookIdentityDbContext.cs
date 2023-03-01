using FPTBook.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Areas.Identity.Data;

public class FPTBookIdentityDbContext : IdentityDbContext<BookUser>
{
    public FPTBookIdentityDbContext(DbContextOptions<FPTBookIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }

    public DbSet<FPTBook.Models.Category> Category { get; set; } = default!;

    public DbSet<FPTBook.Models.Book>? Book { get; set; }

    public DbSet<FPTBook.Models.Author>? Author { get; set; }

    public DbSet<FPTBook.Models.Publisher>? Publisher { get; set; }

    public DbSet<FPTBook.Models.Order> Order { get; set; }
    public DbSet<FPTBook.Models.OrderItem> OrderItem { get; set; }
}
