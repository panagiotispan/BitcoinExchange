<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userpage.aspx.cs" Inherits="userpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="usernamelbl" runat="server"></asp:Label>
            &nbsp
            <asp:Label ID="username_page" runat="server"></asp:Label>
        </div>
        <div>
            
            <asp:Button ID="btndepositbtc" runat="server" OnClick="DepositBtc_Click" Text="Deposit BTC" />   
            
            <asp:TextBox ID="textboxbtc" runat="server"></asp:TextBox>
            
            <br />
          <asp:Button ID="Btndepositusd" runat="server" OnClick="DepositUsd_Click" Text="Deposit USD" />            
            <asp:TextBox ID="textboxusd" runat="server"></asp:TextBox>
        </div>

        <div align="right">
            Bitcoin Balance: <asp:Label ID="bitcoins_balance" runat="server" Text="Label"></asp:Label> / Usd Balance:
            <asp:Label ID="usd_balance" runat="server" Text="Label"></asp:Label>
        </div>
       
        <div>
             <asp:Button ID="Button1" runat="server" OnClick="BuyBitcoin_Click" Text="Buy Bitcoin" />

        &nbsp;&nbsp;&nbsp;
             
             <asp:TextBox ID="Txtbuy" runat="server" autopostback="true" xmlns:asp="#unknown" ontextchanged="TxtBuy_TextChanged"></asp:TextBox>
             
        &nbsp;&nbsp;&nbsp;
       
        <asp:textbox id="txt3" runat="server" autopostback="true" readonly="true" xmlns:asp="#unknown"></asp:textbox>
             
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="SellBitcoin_Click" Text="Sell Bitcoin" /> 
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtsell" runat="server" autopostback="true" xmlns:asp="#unknown" ontextchanged="TxtSell_TextChanged"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt4" runat="server" autopostback="true" readonly="true" xmlns:asp="#unknown"></asp:TextBox>
            </div>

        
        
        <div align="right">  
            
            <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Logout" />        

       <div>



           </div>
        
       
        
        
        
       <div>
    </div>
       
     <div align="left">
            The current value of Bitcoin NOW is: <asp:Label ID="bitcoin_value" runat="server"></asp:Label>
     </div>  
        
        
    </form>
</body>
</html>
