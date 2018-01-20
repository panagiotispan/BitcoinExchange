<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
        .auto-style2 {
            margin-left: 32px;
        }
        .auto-style3 {
            margin-left: 200px;
        }
        .auto-style4 {
            margin-left: 15px;
        }
        .auto-style5 {
            margin-left: 240px;
        }
        .auto-style6 {
            height: 38px;
            width: 432px;
            margin-left: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <div class="auto-style6">
                     <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="tbUsername" runat="server" CssClass="auto-style4" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <br />
            </div>
            <div class="auto-style1">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                      <asp:TextBox ID="tbPassword" runat="server" CssClass="auto-style2" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;

             </div>
             <div class="auto-style3">

                       <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>

               </div>
               <div class="auto-style5">
                        <br />
                        <br />
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" ></asp:Button>

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />

                        <br />
                        <br />
                        <br />

                   </div>
            </div>
       
    </form>
    </body>
</html>
