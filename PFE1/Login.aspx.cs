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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Salle;Integrated Security=True");
        DataTable dt=new DataTable();
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string req = "select * from [User] where UserName='" + Login1.UserName + "' and Pass='" + Login1.Password + "'";
            da = new SqlDataAdapter(req, cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0) { Login1.FailureText = "Le Nom d'Utilisateur ou Mot De Passe est incorrect"; }
            else
            {
                Session["Role"] = dt.Rows[0][2].ToString();
                if (Session["Role"].ToString() == "Assistant")
                    Response.Redirect("~/Assistant/Verification.aspx");
                if (Session["Role"].ToString() == "Manager")
                    Response.Redirect("~/Manager/TableauBoard.aspx");
            }
        }
    }
}