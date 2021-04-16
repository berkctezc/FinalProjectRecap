using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araba eklendi";
        public static string CarInvalid = "Yanlış giriş yapıldı! Araba açıklaması minimum 2 karakter, günlük fiyatı 0'dan büyük olmalıdır.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Sistem bakımda";
        public static string CarsListed = "Ürünler listelendi";
        public static string CarDailyPriceInvalid = "Hatalı araba fiyatı";
        public static string MaintanceTime = "Sistem bakımda";
        //Brand
        internal static string BrandAdded = "Marka eklendi";
        internal static string BrandUpdated = "Marka güncellendi";
        internal static string BrandDeleted = "Marka silindi";
        internal static string BrandsListed = "Markalar listelendi";
        //Color
        internal static string ColorAdded = "Renk eklendi";
        internal static string ColorDeleted = "Renk silindi";
        internal static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        //User
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcı listelendi";
        //Customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteri listelendi";
        //Rental
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalInvalidation = "Araba kirada";
    }
}
