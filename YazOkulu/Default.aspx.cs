using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = "Samet";
        ent.SOYAD = "Arslan";
        ent.NUMARA = "2030";
        ent.MAIL = "sametarslan@gmail.com";
        ent.SIFRE = "1907";
        
        BLLOgrenci.OgrenciEkleBLL(ent);


    }
}