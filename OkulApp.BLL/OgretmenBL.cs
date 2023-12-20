using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet (Ogretmen ogretmen)
        { 
            var helper=new Helper();
            var param = new SqlParameter[]
                {
                    new SqlParameter("@Tc",ogretmen.Tc),
                    new SqlParameter("@Ad",ogretmen.Name),
                    new SqlParameter("@Soyad",ogretmen.Surname),
                    new SqlParameter("@BransKodu",ogretmen.BransKodu)
                };
            return helper.ExecuteNonQuery("Insert into Ogretmen Values (@Tc,@Ad,@Soyad,@BransKodu)", param) > 0;
        }
    }
}
