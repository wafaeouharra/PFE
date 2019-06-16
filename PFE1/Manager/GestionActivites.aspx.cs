using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PFE1.Manager
{
    public partial class GestionActivites : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null) Response.Redirect("~/Login.aspx");
            else if ((string)Session["Role"] != "Manager") { Response.Redirect("~/Assistant/Verification.aspx"); }
        }

        protected void btnAjoutActiv_Click(object sender, EventArgs e)
        {

                string id = (GridView1.FooterRow.FindControl("txtid") as TextBox).Text;
                string nom = (GridView1.FooterRow.FindControl("txtlibelle") as TextBox).Text;
                string prenom = (GridView1.FooterRow.FindControl("txttarif") as TextBox).Text;
                string req = "insert into Activite values(" + id + ",'" + nom + "'," + prenom + ")";
            da = new SqlDataAdapter(req,cn);
                da.Fill(dt);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);
                GridView1.DataBind();
            


        }

        protected void btnAjoutabonn_Click(object sender, EventArgs e)
        {
           
                string id = (GridView2.FooterRow.FindControl("txtidtype") as TextBox).Text;
                string nom = (GridView2.FooterRow.FindControl("txtnomtype") as TextBox).Text;
                string prenom = (GridView2.FooterRow.FindControl("txtreduction") as TextBox).Text;
                string req = "insert into TypeAbonnement values(" + id + ",'" + nom + "','" + prenom + "')";
                da = new SqlDataAdapter(req, cn);
                da.Fill(dt);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);
                GridView2.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}