using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtId;
        public int OGRTID {
            get { return ogrtId; }
            set { ogrtId = value; }
        }

        private String ogrtAdSoyad;
        public String OGRTADSOYAD
        {
            get { return ogrtAdSoyad; }
            set { ogrtAdSoyad = value; }
        }

        private int brans;
        public int BRANS
        {
            get { return brans; }
            set { brans = value; }
        }

    }
}
