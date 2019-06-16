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
    public partial class TableauBoard : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null) Response.Redirect("~/Login.aspx");
            else if ((string)Session["Role"] != "Manager") { Response.Redirect("~/Assistant/Verification.aspx"); }
            else
            {
                if (!Page.IsPostBack)
                {
                    string req = "select count(IDClient) from Client";
                    da = new SqlDataAdapter(req, cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                        lblclts.Text = dt.Rows[0][0].ToString();
                    req = "select count(IDEntraineur) from Entraineur";
                    da = new SqlDataAdapter(req, cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                        lblentr.Text = dt.Rows[0][0].ToString();
                }
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String entraineur = DropDownList2.SelectedValue;
            string req = "select count(IDClient) from Abonnement where IDEntraineur="+entraineur;
            da = new SqlDataAdapter(req, cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                lblnbcltsentr.Text = dt.Rows[0][0].ToString();
            else lblnbcltsentr.Text = "0";

            req = "select count(IDClient)*Tarif from Entraineur E,Activite A,Abonnement Ab where A.IDActivite= E.Specialite and Ab.IDEntraineur=E.IDEntraineur and Ab.IDEntraineur="+entraineur+" group by Tarif";
            da = new SqlDataAdapter(req, cn);
            dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            lblSalaireentr.Text = dt.Rows[0][0].ToString()+" DHS";
            else lblSalaireentr.Text ="0 DHS";

        }
    }
}