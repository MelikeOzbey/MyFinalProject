using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenaceTime = "Bakım zamanı";
        public static string ProductListed = "Ürünler listelendi.";

        public static string ProductCountOfCategoryError = "Ürünler eklenirke hata oluştu";

        public static string ProductNameAlreadyExist = "Bu ürün ismi sistemde mevcuttur.";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied = "Yetkiniz yoktur";
    }
}
