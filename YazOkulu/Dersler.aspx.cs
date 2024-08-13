using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;



public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<EntityDers> entders = BLLDers.BLLDers();
            DropDownList1.DataSource = BLLDers.BLLDers();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "DERSID";
            DropDownList1.DataBind();
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuruFormu ent = new EntityBasvuruFormu();
        ent.OGRID = int.Parse(TextBox1.Text);
        ent.DERSID = int.Parse(DropDownList1.SelectedValue.ToString());
        BLLDers.TalepEkleBLL(ent);
    }
}