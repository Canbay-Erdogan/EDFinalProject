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
        public static string UserRegistered="kullanıcı kayıt oldu";
        public static string UserNotFound="kullanıcı hatalı";
        public static string PasswordError="şifre yanlış";
        public static string SuccessfulLogin="giriş tamamdır";
        public static string UserAlreadyExists="bu kullanıcı var gibi";
        public static string AccessTokenCreated="token oluşturuldu";
    }
}
