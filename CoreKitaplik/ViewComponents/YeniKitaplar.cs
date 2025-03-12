using CoreKitaplik.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreKitaplik.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplist = new List<Kitaplar>
            {
                new Kitaplar
                {
                    Id = 6,
                    KitapAd = "Korku",
                    Yazar = "Zweig"
                },
                new Kitaplar
                {
                    Id = 7,
                    KitapAd = "Anna Karanina",
                    Yazar = "Tolstoy"
                }
            };
            return View(kitaplist);
        }
    }
}
