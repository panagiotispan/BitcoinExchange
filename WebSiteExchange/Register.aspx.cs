using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)

    {

    }




    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && txtEmail.Text.Length > 0)
        {
            WriteToDbServiceReference.WriteToDbClient wtd = new WriteToDbServiceReference.WriteToDbClient();
            WriteToDbServiceReference.Person p = new WriteToDbServiceReference.Person();

            p.Username = txtUsername.Text;
            p.Password = txtPassword.Text;
            p.Email = txtEmail.Text;



            TryLoginReference.TryLoginClient tlc = new TryLoginReference.TryLoginClient();
            Dictionary<string, string> userData = tlc.UserLogin(txtUsername.Text, txtPassword.Text);
            int userId = int.Parse(userData["userId"]);
            if (userId > 0)
            {

                lblError.Text = "User already exists!!";
                lblError.Visible = true;
            }
            else if (userId <= 0)
            {

                lblError.Text = "You have Successfully registered to the exhange!!";
                lblError.Visible = true;

                wtd.InsertPerson(p);

            }
        }
        else if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0 || txtEmail.Text.Length == 0)
        {
            lblError.Text = "Enter Your Details";
            lblError.Visible = true;

        }

    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }
}
