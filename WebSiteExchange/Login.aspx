<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

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
    <div id="login" role="dialog">
    <div class="modal-dialog modal-sm">
      
      <div class="modal-content" id="loginForm">
        <div class="modal-header">
          <h4 class="modal-title text-center form-title">Login</h4>
        </div>
        <div class="modal-body padtrbl">

          <div class="login-box-body">
            <p class="login-box-msg">Sign in to your account</p>
            <div class="form-group">
                <div class="form-group has-feedback">
                  <!----- username -------------->
                     <asp:TextBox ID="tbUsername" runat="server" CssClass="form-control auto-style4" placeholder="Username" ></asp:TextBox>
                </div>
                    <div class="form-group has-feedback">
                  <!----- password -------------->
                     <asp:TextBox placeholder="Password" ID="tbPassword" runat="server" CssClass="form-control auto-style2" type="password" autocomplete="off"></asp:TextBox>
                  <span style="display:none;font-weight:bold; position:absolute;color: grey;position: absolute;padding:4px;font-size: 11px;background-color:rgba(128, 128, 128, 0.26);z-index: 17;  right: 27px; top: 5px;" id="span_loginpsw"></span>
                </div>
                <div class="row">
                  <div class="col-xs-12">
                    <div class="checkbox icheck">
                        <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                    </div>
                  </div>
                  <div class="col-xs-12">
                        <asp:Button ID="btnLogin" class="btn btn-green btn-block btn-flat" runat="server" Text="Login" OnClick="btnLogin_Click" ></asp:Button>
                      <hr />
                      <asp:HyperLink NavigateUrl="Register.aspx" ID="HyperLink1" runat="server" ForeColor="#0033CC">New User? Sign Up Here.</asp:HyperLink>
                  </div>
                </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
        </form>
