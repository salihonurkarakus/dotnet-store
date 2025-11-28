using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class HomeController : Controller
{
   private readonly DataContext _context; // readonly değiştirilmemesini sağlıyor
    public HomeController(DataContext context)
    {
        _context = context;
    }
    public ActionResult Index()
    {
        var products = _context.Urunler.Where(urun => urun.Aktif && urun.Anasayfa).ToList();
        return View(products);
    }
}
