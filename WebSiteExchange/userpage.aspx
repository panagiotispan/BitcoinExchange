<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userpage.aspx.cs" Inherits="userpage" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

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
    <link rel="stylesheet" type="text/css" href="css/userProfile.css">
</head>


<body>

    <form id="form2" runat="server">
    
        <div class="col-lg-10 col-centered">
        <div class="collapse navbar-collapse" id="myNavbar">
        <ul class="nav navbar-nav navbar-right">
        <li class="btn-trial"><a><asp:Button class="navButton" ID="Logout" runat="server" OnClick="Logout_Click" Text="Logout"  /> </a></li> 
            <li><a><asp:Button class="navButton" ID="homepage_btn" runat="server" OnClick="Homepage_Click" Text="Homepage"  /> </a></li>
        </ul>
        </div>
        </div>
                
    <div class="row">
      <div class="col-lg-10 col-centered">
        <div class="card hovercard">
            <div class="useravatar">
                &nbsp;</div> <br /> <br />
            <div class="card-info"> <span class="card-title"><asp:Label ID="usernamelbl" runat="server"></asp:Label></span>
            </div>
        </div>
      </div>
    </div>
   
    
        <div class="row">
            <div class="col-lg-10 col-centered" >
            <table border="0" align="center" style="border-collapse:separate; border-spacing:1em">
                <tr >
                    <td><h3>Bitcoin Balance</h3></td>
                    <td><h3>USD Balance</h3></td>
                </tr>
                <tr align="center" >
                    <td><asp:Label ID="bitcoins_balance" runat="server" Text="Label" CssClass="balancevalue"></asp:Label><span> BTC</span></td>
                    <td><asp:Label ID="usd_balance" runat="server" Text="Label" Class="balancevalue"></asp:Label><span> USD</span></td>
                </tr>
            </table>
            </div>
        </div>
    

    <div class="col-lg-10 col-centered">
            
            <span style="font-weight:bold;font-size:20px; font-style:italic">Deposit / Withdraw USD</span>
            <p></p>
            <div class="row"> 
                    <div class="col-lg-6">
                    <asp:TextBox ID="textboxusd" placeholder="Enter the amount of usd you wish to add to your account" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-lg-6">
                    <asp:TextBox ID="textbox1" placeholder="Enter the amount of usd you wish to withdraw from your account" class="form-control" runat="server"></asp:TextBox>
                    </div>
            </div>
       
            <div class="row">
                <p></p>
                    <div class="col-lg-6">
                    <asp:Button ID="Btndepositusd" runat="server" OnClick="DepositUsd_Click" class="btn btn-block btn-submit" Text="Deposit USD" />  
                    </div>
                    <div class="col-lg-6">
                    <asp:Button ID="Button3" runat="server" OnClick="WithdrawUsd_Click" class="btn btn-block btn-submit" Text="Withdraw USD" />  
                    </div>
            </div>
        
            <hr />

            <span style="font-weight:bold;font-size:20px; font-style:italic">Deposit / Withdraw Bitcoin</span>
            <p></p>    

            <div class="row"> 
                <div class="col-lg-6">
                <asp:TextBox ID="textboxbtc" placeholder="Enter the amount of Bitcoin you wish to add to your account" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                <asp:TextBox ID="textbox3" placeholder="Enter the amount of Bitcoin you wish to withdraw from your account" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <p></p>
                <div class="col-lg-6">
                <asp:Button ID="btndepositbtc" runat="server" OnClick="DepositBtc_Click" class="btn btn-block btn-submit" Text="Deposit Bitcoin" />  
                </div>
                <div class="col-lg-6">
                <asp:Button ID="Button5" runat="server" OnClick="WithdrawBtc_Click" class="btn btn-block btn-submit" Text="Withdraw Bitcoin" />  
                </div>
            </div>
         
            <hr />

            <span style="font-weight:bold;font-size:20px; font-style:italic">Buy / Sell Bitcoin</span>
            <p></p> 

            <div class="row">
                    <div class="col-lg-3">
                        <asp:TextBox ID="Txtbuy" placeholder="BTC amount to buy" runat="server" class="form-control" autopostback="true" xmlns:asp="#unknown" ontextchanged="TxtBuy_TextChanged"></asp:TextBox>
                    </div>
                    <div class="col-lg-3">
                        <asp:textbox id="txt3"  runat="server" class="form-control" autopostback="true" readonly="true" xmlns:asp="#unknown"></asp:textbox> 
                    </div>
                    <div class="col-lg-3">
                    <asp:TextBox ID="Txtsell" placeholder="BTC amount to sell" runat="server" class="form-control" autopostback="true" xmlns:asp="#unknown" ontextchanged="TxtSell_TextChanged"></asp:TextBox>
                    </div>
                    <div class="col-lg-3">
                    <asp:TextBox ID="Txt4" runat="server" class="form-control" autopostback="true" readonly="true" xmlns:asp="#unknown"></asp:TextBox>
                    </div>
            </div>
            <p></p>
            <div class="row">
                <div class="col-lg-6">
                    <asp:Button class="btn btn-block btn-submit" ID="Button1" runat="server" OnClick="BuyBitcoin_Click" Text="Buy Bitcoin" />
                </div>
                <div class="col-lg-6">
                    <asp:Button class="btn btn-block btn-submit" ID="Button2" runat="server" OnClick="SellBitcoin_Click" Text="Sell Bitcoin" /> 
                </div>
            </div>
       </div>
   
    <br />
    <div class="col-md-4 col-sm-4 col-centered">
        <div class="price-table">
            <div class="pricing-head">
                <h4>Live Bitcoin Price</h4>
                <span class="fa fa-usd curency"></span> <span class="amount"><asp:Label ID="current_bitcoin_value" runat="server"></asp:Label></span>
            </div>
            <div class="price-in mart-15">
                <span class="btn-bg green btn-block"></span>
            </div>
        </div>
   </div> 
        
   </form>


      <script src="js/jquery.min.js"></script>
  <script src="js/jquery.easing.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/custom.js"></script>
  <script src="contactform/contactform.js"></script>
    <script src="js/userProfile.js"> </script>

</body>
</html>
