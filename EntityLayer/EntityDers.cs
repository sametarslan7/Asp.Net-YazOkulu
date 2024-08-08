using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityDers
    {
        private int dersId;
        public int DERSID {
            get { return dersId; }
            set { dersId = value; }
        }

        private String dersAd;
        public String DERSAD;
        {
            get { return dersAd; }
            set { dersAd = value; }
        }

        private int dersMax;
        public int DERSMAX;
        {
            get { return dersMax; }
            set { dersMax = value; }
        }

        private int dersMin;
        public int DERSMIN;
        {
            get { return dersMin; }
            set { dersMin = value; }
        }

    }
}
