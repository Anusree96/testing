using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class viewcomp : System.Web.UI.Page
{
    string s = System.Configuration.ConfigurationManager.ConnectionStrings["cleaning"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(s);
        con.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("select * from compreqtbl where status='submited'",con);
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);
        GridView1.DataSource = dtbl;
        GridView1.DataBind();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void lnkap_Click(object sender, EventArgs e)
    {
        LinkButton lnk = sender as LinkButton;
        GridViewRow gridrow = lnk.NamingContainer as GridViewRow;
        int row = gridrow.RowIndex;
        string cid = GridView1.Rows[row].Cells[0].Text;
        SqlConnection con = new SqlConnection(s);
        con.Open();
        string q = "update compreqtbl set status='" + "Approve" + "' where cid='"+cid+"'";
        SqlCommand cmd = new SqlCommand(q, con);
        int a=cmd.ExecuteNonQuery();
        if (a > 0)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from compreqtbl where status='submited'", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            GridView1.DataSource = dtbl;
            GridView1.DataBind();
           
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
}