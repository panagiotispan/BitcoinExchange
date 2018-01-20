using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0)
        {


            lblError.Visible = false;

            TryLoginReference.TryLoginClient tlc = new TryLoginReference.TryLoginClient();


            Dictionary<string, string> userData = tlc.UserLogin(tbUsername.Text, tbPassword.Text);
            int userId = int.Parse(userData["userId"]);
            if (userId > 0)
            {


                GetUserInfoReference.GetUserInfoClient guic = new GetUserInfoReference.GetUserInfoClient();
                Dictionary<string, string> userInfo = guic.GetUserInformation(userId);

                Response.Redirect("Userpage.aspx?userId=" + userId);


            }
            else
            {
                lblError.Text = "Wrong Username or Password";
                lblError.Visible = true;

            }
        }

        else
        {
            lblError.Text = "Please insert username and password";
            lblError.Visible = true;

        }



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}





