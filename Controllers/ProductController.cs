
using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class ProductController: Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context; // readonly değiştirilmemesini sağlıyor
    public ProductController(DataContext context)
    {
        _context = context;
    }
    public ActionResult Index()
    {
        // Sorguyu ilgili sql e çevrilmesi sağlanıyor
        var products = _context.Urunler.ToList();
        ;
        return View(products);
    }
}