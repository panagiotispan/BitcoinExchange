<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    

    <form id="form1" runat="server">
        
        <div align="left">
            The current value of Bitcoin NOW is: <asp:Label ID="bitcoin_value" runat="server"></asp:Label>
        </div>

        <div  align="right">
            <asp:Button ID="login_home" runat="server" Text="Login" OnClick="login_home_Click" />
            <asp:Button ID="register_home" runat="server" Text="Register" OnClick="register_home_Click" />
        </div>

    </form>
    <br />
    <img  src="https://www.startupworld.com/wp-content/uploads/2017/12/usebitcoin-4096x2253.jpg" width="100%" height="800px"/>&nbsp;

</body>
</html>
