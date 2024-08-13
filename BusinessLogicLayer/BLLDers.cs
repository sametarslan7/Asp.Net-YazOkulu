using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    class BLLDers
    {
        public static List<EntityDers> BLLDers()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruFormu p)
        {
            if(p.OGRID != null && p.DERSID != null)
            {
                return DALDers.DALTalepEkle(p);
            }
            return -1;
        }
    }
}
