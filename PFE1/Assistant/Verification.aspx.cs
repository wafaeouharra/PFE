using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PFE1.Assistant
{
    public partial class Verification : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt,dtac;
        SqlDataAdapter da,dac;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null) Response.Redirect("~/Login.aspx");
            else
            {
                if (!Page.IsPostBack)
                {
                    DDLActivite.Enabled = false;
                    DDLTypeAbonn.Enabled = false;
                    DDLEntraineur.Enabled = false;
                    TxtID.Focus();
                }

            }

        }

        protected void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Modifier")
            {
                btnModif.Text = "Enregistrer";
                DDLActivite.Enabled = true;
                DDLTypeAbonn.Enabled = true;
                DDLEntraineur.Enabled = true;
            }
            else
            {
                string reqmod = "update Abonnement set IDActivite="+DDLActivite.SelectedValue+",IDType="+DDLTypeAbonn.SelectedValue+" where IDClient="+TxtID.Text;
                DataTable dtmod = new DataTable();
                SqlDataAdapter damod = new SqlDataAdapter(reqmod,cn);
                damod.Fill(dtmod);
                SqlCommandBuilder cmd = new SqlCommandBuilder(damod);
                damod.Update(dtmod);
                btnModif.Text = "Modifier";
                DDLActivite.Enabled = false;
                DDLTypeAbonn.Enabled = false;
                DDLEntraineur.Enabled = false;
            }
        }

        protected void btnAnnul_Click(object sender, EventArgs e)
        {
            String req = "select * from Client where IDClient=" + TxtID.Text;
            da = new SqlDataAdapter(req, cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                verifier(dt);
            else { TxtID.Text = lblnom.Text = lblprenom.Text = lblSituation.Text = lbltelephone.Text = ""; }
            DDLActivite.Enabled = false;
            DDLTypeAbonn.Enabled = false;
            DDLEntraineur.Enabled = false;
            btnModif.Text = "Modifier";
            TxtID.Focus();

        }

        protected void btnverif_Click(object sender, EventArgs e)
        {
            try
            {
                String req = "select * from Client where IDClient=" + TxtID.Text;
                da = new SqlDataAdapter(req, cn);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                lblSituation.Text = "Ce Client n'existe pas";
            }
            if (dt.Rows.Count == 0)
            {
                lblSituation.Text = "Ce Client n'existe pas";
                lblSituation.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                verifier(dt);  
            }
            TxtID.Focus();

        }
        private void verifier(DataTable dt)
        {
            lblnom.Text = dt.Rows[0][1].ToString();
            lblprenom.Text = dt.Rows[0][2].ToString();
            lbltelephone.Text = dt.Rows[0][3].ToString();
            dac = new SqlDataAdapter("select * from Abonnement where IDClient =" + TxtID.Text, cn);
            dtac = new DataTable();
            dac.Fill(dtac);
            if(dtac.Rows.Count!=0)
            {
                DDLActivite.SelectedValue = dtac.Rows[0][2].ToString();
                DDLTypeAbonn.SelectedValue = dtac.Rows[0][3].ToString();
                if (DateTime.Compare(DateTime.Parse(dtac.Rows[0][5].ToString()), DateTime.Today) > 0)
                {
                    lblSituation.Text = "Valide(Paye)";
                    lblSituation.ForeColor = System.Drawing.Color.ForestGreen;
                }
                else {
                    lblSituation.Text = "Non Valide(Non Paye)";
                    lblSituation.ForeColor = System.Drawing.Color.IndianRed;
                }
            }
        }

    }
}