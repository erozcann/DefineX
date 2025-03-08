using System.ComponentModel.DataAnnotations;
using ZorunluAlanLibrary; // Class Library kullanımı

namespace MvcZorunluKontrol.Models
{
    public class Ogrenci
    {
        [ZorunluAlan]
        [Required(ErrorMessage = "Adı boş bırakılamaz.")]
        public string Adi { get; set; }

        [ZorunluAlan]
        [Required(ErrorMessage = "Soyadı boş bırakılamaz.")]
        public string Soyadi { get; set; }

        [ZorunluAlan]
        [Required(ErrorMessage = "Bölüm boş bırakılamaz.")]
        public string Bolum { get; set; }
    }
}
