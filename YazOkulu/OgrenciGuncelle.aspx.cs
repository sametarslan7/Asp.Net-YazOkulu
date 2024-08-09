using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;


public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        TextId.Text = x.ToString();
        TextId.Enabled = false;
        
        EntityOgrenci ent= new EntityOgrenci();
        List<EntityOgrenci> OgrList = BLLOgrenci.BLLOgrenciDetay(x);

        TextAd.Text = OgrList[0].AD.ToString();
        TextSoyad.Text = OgrList[0].SOYAD.ToString();
        TextNumara.Text = OgrList[0].NUMARA.ToString();
        TextMail.Text = OgrList[0].MAIL.ToString();
        TextSifre.Text = OgrList[0].SIFRE.ToString();


    }
}