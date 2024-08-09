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

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLOgrenciDetay(x);

            TextAd.Text = OgrList[0].AD.ToString();
            TextSoyad.Text = OgrList[0].SOYAD.ToString();
            TextNumara.Text = OgrList[0].NUMARA.ToString();
            TextMail.Text = OgrList[0].MAIL.ToString();
            TextSifre.Text = OgrList[0].SIFRE.ToString();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = TextAd.Text;
        ent.SOYAD = TextSoyad.Text;
        ent.NUMARA = TextNumara.Text;
        ent.MAIL = TextMail.Text;
        ent.SIFRE = TextSifre.Text;
        ent.ID = Convert.ToInt32(TextId.Text);

        BLLOgrenci.OgrenciGuncelleBLL(ent);
        response.redirect("OgrenciListele.aspx");
    }
}