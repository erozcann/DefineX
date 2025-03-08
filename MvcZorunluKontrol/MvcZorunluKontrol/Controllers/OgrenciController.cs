using System.Web.Mvc;
using MvcZorunluKontrol.Models;
using ZorunluAlanLibrary; // Class Library kullanımı

namespace MvcZorunluKontrol.Controllers
{
    public class OgrenciController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ogrenci ogrenci)
        {
            if (!ZorunluAlanAttribute.Dogrula(ogrenci) || !ModelState.IsValid)
            {
                ViewBag.Mesaj = "Öğrenci bilgileri eksik!";
            }
            else
            {
                ViewBag.Mesaj = "Form başarılı!";
            }

            return View(ogrenci);
        }
    }
}
