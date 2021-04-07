using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarInvalid = "Yanlış giriş yapıldı! Araba açıklaması minimum 2 karakter, günlük fiyatı 0'dan büyük olmalıdır.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Sistem bakımda";
        public static string CarsListed = "Ürünler listelendi";
        public static string MaintanceTime = "Sistem bakımda";
        internal static string ColorAdded = "Renk eklendi";
        internal static string ColorDeleted = "Renk silindi";
        internal static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        internal static string BrandAdded = "Marka eklendi";
        internal static string BrandUpdated = "Marka güncellendi";
        internal static string BrandDeleted = "Marka silindi";
        internal static string BrandsListed = "Markalar listelendi";
    }
}
