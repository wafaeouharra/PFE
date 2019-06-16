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
    public partial class GestionEntraineurs : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null) Response.Redirect("~/Login.aspx");
            else if ((string)Session["Role"] != "Manager") { Response.Redirect("~/Assistant/Verification.aspx"); }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int n = e.NewSelectedIndex;
            string id = GridView1.Rows[n].Cells[4].Text;
            da = new SqlDataAdapter("select * from Activite where IDActivite="+id,cn);
            da.Fill(dt);
            Label1.Text = "Les informations sur la specialite:";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label1.Text += "<br/>* Libelle :" + dt.Rows[i][1].ToString() + "<br/>* Tarif :" + dt.Rows[i][2].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = (GridView1.FooterRow.FindControl("txtid") as TextBox).Text;
            string nom = (GridView1.FooterRow.FindControl("txtnom") as TextBox).Text;
            string prenom = (GridView1.FooterRow.FindControl("txtprenom") as TextBox).Text;
            string tel = (GridView1.FooterRow.FindControl("DropDownList1") as DropDownList).SelectedValue;
            string req = "insert into Entraineur values(" + id + ",'" + nom + "','" + prenom + "','" + tel + "')";
            da = new SqlDataAdapter(req, cn);
            da.Fill(dt);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            GridView1.DataBind();
        }
    }
}