using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class log : System.Web.UI.Page
{
    string s = System.Configuration.ConfigurationManager.ConnectionStrings["cleaning"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "User")
        {
            string p = "select password from userregtbl where username='" + TextBox1.Text + "'";
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand(p, con);
            string password = Convert.ToString(cmd.ExecuteScalar());
            if (password == TextBox2.Text)
            {
                Session["user"] = TextBox1.Text;
                Response.Redirect("userhome.aspx");
            }
            else
            {
                Label5.Visible = true;
                Label5.Text = "Invalid userid or password";
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Company")
            {
                string p = "select password from compregtbl where userid='" + TextBox1.Text + "'";
                SqlConnection con = new SqlConnection(s);
                con.Open();
                SqlCommand cmd = new SqlCommand(p, con);
                string password = Convert.ToString(cmd.ExecuteScalar());
                if (password == TextBox2.Text)
                {
                    Session["company"] = TextBox1.Text;
                    Response.Redirect("companyhome.aspx");
                }
                else
                {
                    Label5.Visible = true;
                    Label5.Text = "Invalid userid or password";
                }
            }
        else if (TextBox1.Text == "ADMIN")
        {
            if (TextBox2.Text == "ADMIN")
            {
                Response.Redirect("adminhome.aspx");
            }
            else
            {
                Label5.Visible = true;
                Label5.Text = "Invalid userid or password";
            }
        }
       
    }
protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{

}
}