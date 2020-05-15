using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class companyhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewreq.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("compreq.aspx");
    }
  
}