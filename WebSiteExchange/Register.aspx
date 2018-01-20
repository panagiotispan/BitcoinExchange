<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 120px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">

        <div>
            <div>
                     <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                     &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                     <br />
                     <br />
            </div>
            <div>
                      <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                      <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
                      <br />
                      <br />
                      <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
&nbsp;

                       <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>

             </div>
             <div class="auto-style1">

                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />

                        &nbsp;&nbsp;&nbsp;

               </div>
               <div class="auto-style2">

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink NavigateUrl="Login.aspx" ID="HyperLink1" runat="server" ForeColor="#0033CC">Already Registered? Log in.</asp:HyperLink>
                        <br />
&nbsp;<br />
                        <br />
                        <br />

                   </div>
            </div>
       
    </form>
    </body>
</html>

