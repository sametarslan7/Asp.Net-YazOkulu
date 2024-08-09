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
    }
}
