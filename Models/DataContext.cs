using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext // DbContext sınıfının özelliklerini miras yolu ile DataContext içerisine aktarılıyor
{
    // yapıcı metotlar 
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Product> Urunler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new List<Category>
            {
                new Category {Id=1,KategoriAdi="Telefon",Url="telefon"},
                new Category {Id=2,KategoriAdi="Elektronik",Url="elektronik"},
                new Category {Id=3,KategoriAdi="Beyaz Eşya",Url="beyaz-esya"},
                new Category {Id=4,KategoriAdi="Giyim",Url="giyim"},
                new Category {Id=5,KategoriAdi="Kozmetik",Url="kozmetik"},
            }

        );

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() {
                    Id = 1, 
                    UrunAdi = "Apple Watch 7", 
                    Fiyat = 10000, 
                    Aktif = false, 
                    Resim="1.jpeg",
                    Anasayfa=true, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=1 
                    },
                new Product() {
                    Id = 2, 
                    UrunAdi = "Apple Watch 8", 
                    Fiyat = 20000, 
                    Aktif = true, 
                    Resim="2.jpeg",
                    Anasayfa=true, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=1 
                    },
                new Product() {
                Id = 3, 
                UrunAdi = "Apple Watch 9", 
                Fiyat = 30000, 
                Aktif = true, 
                Resim="3.jpeg",
                Anasayfa=true, 
                Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=2 
                },
                new Product() {
                    Id = 4, 
                    UrunAdi = "Apple Watch 10", 
                    Fiyat = 40000, 
                    Aktif = false , 
                    Resim="4.jpeg",
                    Anasayfa=false, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=2
                    },
                new Product() {Id = 5, 
                UrunAdi = "Apple Watch 11", 
                Fiyat = 50000, 
                Aktif = true, 
                Resim="5.jpeg",
                Anasayfa=true, 
                Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                CategoryId=2
                },
                new Product() {
                    Id = 6, 
                    UrunAdi = "Apple Watch 12", 
                    Fiyat = 60000, 
                    Aktif = false, 
                    Resim="6.jpeg",
                    Anasayfa=false, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=3 
                    },
                new Product() {
                    Id = 7, 
                    UrunAdi = "Apple Watch 13", 
                    Fiyat = 70000, 
                    Aktif = false, 
                    Resim="7.jpeg",
                    Anasayfa=false, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=3 
                    },
                new Product() {
                    Id = 8, 
                    UrunAdi = "Apple Watch 14", 
                    Fiyat = 80000, 
                    Aktif = true, 
                    Resim="8.jpeg",
                    Anasayfa=true, 
                    Aciklama=" is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    CategoryId=4
                    }
            }
        );

    }
}


// Connection String
//  Migrations

