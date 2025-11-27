using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext // DbContext sınıfının özelliklerini miras yolu ile DataContext içerisine aktarılıyor
{
    // yapıcı metotlar 
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
    public DbSet<Product> Urunler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() {Id = 1, UrunAdi = "Apple Watch 7", Fiyat = 10000, Aktif = false },
                new Product() {Id = 2, UrunAdi = "Apple Watch 8", Fiyat = 20000, Aktif = true },
                new Product() {Id = 3, UrunAdi = "Apple Watch 9", Fiyat = 30000, Aktif = true },
                new Product() {Id = 4, UrunAdi = "Apple Watch 10", Fiyat = 40000, Aktif = false },
                new Product() {Id = 5, UrunAdi = "Apple Watch 11", Fiyat = 50000, Aktif = true },
                new Product() {Id = 6, UrunAdi = "Apple Watch 12", Fiyat = 60000, Aktif = true },
            }
        );
    
    }
}

    
// Connection String
//  Migrations

