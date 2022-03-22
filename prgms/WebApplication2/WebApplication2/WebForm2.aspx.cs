using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            // string cs = "server=HOME-PC\SQLEXPRESS;database=mydatabasenew;Trusted_connection=true;";
            // SqlConnection conn = new SqlConnection(cs);
            int eno = int.Parse(txteno.Text);
            string ename = txtename.Text;
            double esal = double.Parse(txtesal.Text);
            SqlCommand cmd = new SqlCommand("Insert into Emp Values(@eno,@ename,@esal)", conn);
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@esal", esal);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i == 1)
            {
                LblMsg.Text = "record is inserted";
            }
            else
            {
                LblMsg.Text = "record is not inserted......";
            }

            txteno.Text = " ";
            txtename.Text = " ";
            txtesal.Text = " ";
            txteno.Focus();
        }
        
    }
}