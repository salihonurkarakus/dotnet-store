
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
    public ActionResult List(string url)
    {
        // Sorguyu ilgili sql e çevrilmesi sağlanıyor
        var products = _context.Urunler.Where(i => i.Aktif && i.Category.Url==url).ToList();
        ;
        return View(products);
    }

    public ActionResult Details(int id)
    {
        var urun = _context.Urunler.Find(id);

        if (urun == null)
        {
            return RedirectToAction("Index","Home");
        }
        ViewData["BenzerUrunler"] = _context.Urunler.Where(i => i.Aktif && i.CategoryId == urun.CategoryId && i.Id != id).Take(4).ToList();

        return View(urun);
    }
}