using CoreKitaplik.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreKitaplik.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){Id = 1, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitaplar(){Id = 2, KitapAd = "Dr Ox'un Deneyi", Yazar = "Jules Verne" },
                new Kitaplar(){Id = 3, KitapAd = "Delifişek", Yazar = "Vasconcelos" },
                new Kitaplar(){Id = 4, KitapAd = "Kırmızı Bisiklet", Yazar = "Muzaffer İzgü" },
                new Kitaplar(){Id = 5, KitapAd = "Toros Canavarı", Yazar = "Aziz Nesin" }
            };
            return View(ktp);
        }

        public IActionResult Deneme()
        {
            return View();
        }

        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
