using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext // DbContext sınıfının özelliklerini miras yolu ile DataContext içerisine aktarılıyor
{
    public DbSet<Product> Urunler { get; set; }
}

// Connection String
//  Migrations