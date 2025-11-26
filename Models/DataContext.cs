using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext // DbContext sınıfının özelliklerini miras yolu ile DataContext içerisine aktarılıyor
{
    // yapıcı metotlar 
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
    public DbSet<Product> Urunler { get; set; }
}

// Connection String
//  Migrations

