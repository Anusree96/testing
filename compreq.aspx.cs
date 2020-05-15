using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class compreq : System.Web.UI.Page
{
    string s = System.Configuration.ConfigurationManager.ConnectionStrings["cleaning"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(s);
        con.Open();
        TextBox5.Text = "submited";
        string query = "insert into compreqtbl values('" + TextBox1.Text + "','"+TextBox6.Text+"','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+TextBox5.Text+"')";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
        Label6.Text = "Submitted";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("companyhome.aspx");
    }
}