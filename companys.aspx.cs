using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class companys : System.Web.UI.Page
{
    string s = System.Configuration.ConfigurationManager.ConnectionStrings["cleaning"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(s);
        con.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("select * from compreqtbl where status='Approve'", con);
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);
        GridView1.DataSource = dtbl;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}