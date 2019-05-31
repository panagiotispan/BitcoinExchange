<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Bitcoin Exchange</title>
  <meta name="description" content="Free Bootstrap Theme by BootstrapMade.com">
  <meta name="keywords" content="free website templates, free bootstrap themes, free template, free bootstrap, free website template">

  <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Open+Sans|Candal|Alegreya+Sans">
  <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css">
  <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
  <link rel="stylesheet" type="text/css" href="css/imagehover.min.css">
  <link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>


    <form id="form1" runat="server">

    <div id="register" role="dialog">
    <div class="modal-dialog modal-sm">
      
      <div class="modal-content" id="registerForm">
        <div class="modal-header">
          <h4 class="modal-title text-center form-title">Register</h4>
        </div>
        <div class="modal-body padtrbl">

          <div class="login-box-body">
            <p class="login-box-msg">Create your account</p>
            <div class="form-group">
                <div class="form-group has-feedback">
                  <!----- email -------------->
                     <asp:TextBox placeholder="Email" ID="txtEmail" runat="server" CssClass="form-control auto-style2" autocomplete="off" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                </div>
                <div class="form-group has-feedback">
                  <!----- username -------------->
                     <asp:TextBox ID="txtUsername"  runat="server" CssClass="form-control auto-style4" placeholder="Username" ></asp:TextBox>
                </div>
                    <div class="form-group has-feedback">
                  <!----- password -------------->
                     <asp:TextBox placeholder="Password" ID="txtPassword" runat="server" CssClass="form-control auto-style2" type="password" autocomplete="off"></asp:TextBox>
                </div>
                <div class="row">
                  <div class="col-xs-12">
                    <div class="checkbox icheck">
                          <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                    </div>
                  </div>
                  <div class="col-xs-12">
                        <asp:Button ID="Button1" class="btn btn-green btn-block btn-flat" runat="server" Text="Register" OnClick="Button1_Click"></asp:Button>
                        <hr />  
                      <asp:HyperLink NavigateUrl="Login.aspx" ID="HyperLink1" runat="server" ForeColor="#0033CC">Already Registered? Log in.</asp:HyperLink>
                  </div>
                </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
      
    </form>
    </body>
</html>

