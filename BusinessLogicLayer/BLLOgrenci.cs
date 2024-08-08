using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci parametre)
        {
            if (parametre.AD != null && parametre.SOYAD != null
                && parametre.NUMARA != null && parametre.MAIL != null
                && parametre.SIFRE != null)
            {
                return DALOgrenci.OgrenciEkle(parametre);
            }
            return -1;
        }
        public List<EntityOgrenci> BLLOgrenciListesi()
        {
            return DALOgrenci.OgrenciListesi();
        }
    }
}
