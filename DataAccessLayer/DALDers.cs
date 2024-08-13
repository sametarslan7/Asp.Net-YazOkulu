using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("select * from TBLDERSLER", Baglanti.bgl);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["DERSID"]);
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.DERSMIN = int.Parse(dr["DERSMINKONT"].ToString());
                ent.DERSMAX = int.Parse(dr["DERSMAXKONT"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
    public static int DALTalepEkle(EntityBasvuruFormu parametre)
    {
        SqlCommand komut2 = new SqlCommand("insert into TBLBASVURUFORMU (OGRID,DERSID) values (@p1,@p2)", Baglanti.bgl);
        komut2.Parameters.AddWithValue("@p1", parametre.OGRID);
        komut2.Parameters.AddWithValue("@p2", parametre.DERSID);
        if(komut2.Connection.State!=ConnectionState.Open)
        {
            komut2.Connection.Open();
        }
        return komut2.ExecuteNonQuery();
    }
}
