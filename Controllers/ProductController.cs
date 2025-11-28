
using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class ProductController : Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context; // readonly değiştirilmemesini sağlıyor
    public ProductController(DataContext context)
    {
        _context = context;
    }
    public ActionResult Index()
    {
        return View();
    }
    public ActionResult List()
    {
        // Sorguyu ilgili sql e çevrilmesi sağlanıyor
        var products = _context.Urunler.Where(i => i.Aktif).ToList();
        ;
        return View(products);
    }

    public ActionResult Details(int id)
    {
        var urun = _context.Urunler.Find(id);

        // EĞER ÜRÜN BULUNAMAZSA:
        if (urun == null)
        {
            // Kullanıcıya "Bulunamadı" hatası (404) dönüyoruz.
            // Böylece uygulama çökmüyor, tarayıcıda düzgün bir hata sayfası çıkıyor.
            return NotFound();
        }

        return View(urun);
    }
}