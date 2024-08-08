using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer
{
    public class EntityOgrenci
    {
        private String ad;
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        private String soyad;
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private String numara;
        public string NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }

        private String mail;
        public string MAIL
        {
            get { return mail; }
            set { mail = value; }
        }
        private String sifre;
        public string SIFRE
        {
            get { return sifre; }
            set { sifre = value; }
        }

        private double bakiye;
        public double BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }


    }
}
