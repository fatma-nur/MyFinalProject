using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static verince new lemez
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez.";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemez.";
    }
}
