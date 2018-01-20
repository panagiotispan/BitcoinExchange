using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        String userId = Request.QueryString["userId"];
        username_page.Text = userId;


        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));

        usernamelbl.Text = "Hello " + userData["username"];

        usd_balance.Text = userData["usd_balance"];

        bitcoins_balance.Text = userData["bitcoins_balance"];


        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        string data = getbtcliveprice.DoWork();
        bitcoin_value.Text = data;
    }

    protected void DepositUsd_Click(object sender, EventArgs e)
    {
        String userId = Request.QueryString["userId"];

        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();
        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();
        double additionalusd = Convert.ToDouble(textboxusd.Text);

        if (additionalusd < 0)
        {
            additionalusd = 0;
        }

        updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, additionalusd);

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        usd_balance.Text = userData["usd_balance"];


    }

    protected void DepositBtc_Click(object sender, EventArgs e)
    {
        String userId = Request.QueryString["userId"];

        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));

        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        double additionalbtc = Convert.ToDouble(textboxbtc.Text);
        if (additionalbtc < 0)
        {
            additionalbtc = 0;
        }

        

        updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, additionalbtc);

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }




    protected void BuyBitcoin_Click(object sender, EventArgs e)
    {
        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();
        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        BuyBtcReference.BuyBtcClient buybtc = new BuyBtcReference.BuyBtcClient();


        String userId = Request.QueryString["userId"];


        double btcamounttobuy = Convert.ToDouble(Txtbuy.Text);

        string btcliveprice = getbtcliveprice.DoWork();

        double amounttobuy = buybtc.DoWork(btcamounttobuy, btcliveprice);

        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

       

        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();

        if (amounttobuy < currentusdbalance && amounttobuy > 0)
        {
            updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, -amounttobuy);
        }
        

        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));
        

        double additionalbtc = Convert.ToDouble(Txtbuy.Text);

        if (amounttobuy < currentusdbalance && amounttobuy > 0)
        {
            updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, additionalbtc);

        }




        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];
        usd_balance.Text = userData["usd_balance"];




    }

    protected void SellBitcoin_Click(object sender, EventArgs e)
    {

        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();
        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        BuyBtcReference.BuyBtcClient buybtc = new BuyBtcReference.BuyBtcClient();

        String userId = Request.QueryString["userId"];


        double btcamounttosell = Convert.ToDouble(Txtsell.Text);

        string btcliveprice = getbtcliveprice.DoWork();

        double amounttosell = buybtc.DoWork(btcamounttosell, btcliveprice);


        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();

        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));

        if (currentbtcbalance > 0 && btcamounttosell > 0)
        {
              updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, amounttosell);
        }


        double additionalbtc = Convert.ToDouble(Txtsell.Text);

        if (currentbtcbalance > 0 && btcamounttosell > 0)
        {
            updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, -additionalbtc);
        }
        

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];
        usd_balance.Text = userData["usd_balance"];
    }




    protected void TxtBuy_TextChanged(object sender, EventArgs e)
    {

        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();

        string btcprice = getbtcliveprice.DoWork();
        double curentbtcprice = Convert.ToDouble(btcprice); ;


        if ((!string.IsNullOrEmpty(Txtbuy.Text)))
        {
            double data2 = Convert.ToDouble(Txtbuy.Text);
            double data3 = (curentbtcprice * data2);
            if (data2 > 0)
            {
                txt3.Text = (Convert.ToDouble(data3).ToString());
            }
            if (data2 < 0)
            {
                txt3.Text = (Convert.ToDouble(0).ToString());
            }

        }
    }





    protected void TxtSell_TextChanged(object sender, EventArgs e)
    {
        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();

        string btcprice = getbtcliveprice.DoWork();
        double curentbtcprice = Convert.ToDouble(btcprice); ;


        if ((!string.IsNullOrEmpty(Txtsell.Text)))
        {
            double data2 = Convert.ToDouble(Txtsell.Text);
            double data3 = (curentbtcprice * data2);
            if (data2 > 0)
            {
                Txt4.Text = (Convert.ToDouble(data3).ToString());
            }
            if (data2 < 0)
            {
                Txt4.Text = (Convert.ToDouble(0).ToString());
            }
        }

    }
    
}