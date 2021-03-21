using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintanceTime = "bakım zamanı";
        public static string ProductListed = "bakım zamanı";
        public static string ProductCountOfCategoryError = "bu kategori 10 ürünü geçemez";
        public static string ProductNameAlreadyExist = "bu ürün var";
        public static string CategoryLimitExceded = "kategori limt aşıldı";
        public static string AuthorizationDenied= "Yetkin Yok ";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
