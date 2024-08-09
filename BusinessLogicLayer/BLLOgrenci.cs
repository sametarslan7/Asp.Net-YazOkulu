using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using System.Reflection.Metadata;


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
        public static List<EntityOgrenci> BLLOgrenciListesi()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if(p>=0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLOgrenciDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null
            && p.NUMARA != null && p.MAIL != null
                && p.SIFRE != null)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
