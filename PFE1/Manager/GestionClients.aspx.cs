using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PFE1
{
    public partial class GestionClients : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt=new DataTable();
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null) Response.Redirect("~/Login.aspx");
            else if ((string)Session["Role"] != "Manager") { Response.Redirect("~/Assistant/Verification.aspx"); }
        }
        protected void BtnAjout_Click(object sender, EventArgs e)
        {
            string id = (GridView1.FooterRow.FindControl("txtid") as TextBox).Text;
            string nom =(GridView1.FooterRow.FindControl("txtnom") as TextBox).Text;
            string prenom = (GridView1.FooterRow.FindControl("txtprenom") as TextBox).Text;
            string tel = (GridView1.FooterRow.FindControl("txttel") as TextBox).Text;
            string req = "insert into Client values("+id+",'"+nom+"','"+prenom+"','"+tel+"')";
            da = new SqlDataAdapter(req,cn);
            da.Fill(dt);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            GridView1.DataBind();
        }
    }
}