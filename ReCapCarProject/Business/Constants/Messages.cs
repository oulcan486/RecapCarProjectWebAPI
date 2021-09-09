using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        internal static string ProductsListed="kayıtlar Listelendi";
        internal static string ProductAdded="Veri Eklendi";
        internal static IResult ProductLoad;
        internal static string ProductUpdated="Ürün Güncellendi";
        internal static string ProductDeleted="Ürün Başarıyla Silindi";
        internal static string GetProductById="Id ye göre ürün bulundu";
        internal static string Fail="İşlem Başarısız oldu";
        internal static string RentalAdded="Araba kiralandı";
        internal static string RentalListed="Kiralık Arabalar Listelendi";
        internal static string GetCarfail="Arabalar listelenemedi";
        internal static string RentalUpdated="Kiralanan Arabanın kayıtları Güncellendi";
        internal static string RentalDelete="Kiralık kaydı sistemden silindi";
        internal static string UserAdded="Kullanıcı Eklendi";
        internal static string UserDeleted="Kullanıcı Silindi";
        internal static string UserUpdated="Kullanıcı Güncellendi";
        internal static string UserListed="Kullanıcılar Listelendi";
        internal static string GetUserById = "Kullanıcı Silindi Kaydı Listelendi";
    }
}
