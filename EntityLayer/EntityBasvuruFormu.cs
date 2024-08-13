using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruFormu
    {
        private int basvuruId;
        public int BASVURUID
        {
            get { return basvuruId; }
            set { basvuruId = value; }
        }

        private int basvuruOgrId;
        public int OGRID
        {
            get { return basvuruOgrId; }
            set { basvuruOgrId = value; }
        }

        private int basvuruDersId;
        public int DERSID
        {
            get { return basvuruDersId; }
            set { basvuruDersId = value; }
        }

    }
}
