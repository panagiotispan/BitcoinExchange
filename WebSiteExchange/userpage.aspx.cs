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

                System.IFormatProvider cultureUS =
   new System.Globalization.CultureInfo("en-US");

        String userId = Request.QueryString["userId"];


        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));

        usernamelbl.Text = "Hello " + userData["username"];

        usd_balance.Text = userData["usd_balance"];

        bitcoins_balance.Text = userData["bitcoins_balance"];


        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        string data = getbtcliveprice.DoWork();
        if (data == "Http request Failed!")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cannot Get Btc Price!!');", true);
        }
        current_bitcoin_value.Text = data;
    }

    protected void DepositUsd_Click(object sender, EventArgs e)
    {
        String userId = Request.QueryString["userId"];

        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();
        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();
        double additionalusd = double.Parse(textboxusd.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

        string removeCommaFromAmmount = additionalusd.ToString();

        if (additionalusd < 0)
        {
            additionalusd = 0;
        }
        
        updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, additionalusd);

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        usd_balance.Text = userData["usd_balance"];

        textboxusd.Text = null;
    }

    protected void DepositBtc_Click(object sender, EventArgs e)
    {
        String userId = Request.QueryString["userId"];

        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));

        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        //double additionalbtc = double.Parse(textboxbtc.Text, System.Globalization.CultureInfo.InvariantCulture);
        double additionalbtc = double.Parse(textboxbtc.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);


        if (additionalbtc < 0)
        {
            additionalbtc = 0;
        }



        updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, additionalbtc);

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];

        textboxbtc.Text = null;
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Homepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }




    protected void BuyBitcoin_Click(object sender, EventArgs e)
    {
        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();
        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        BuyBtcReference.BuyBtcClient buybtc = new BuyBtcReference.BuyBtcClient();


        String userId = Request.QueryString["userId"];


        //double btcamounttobuy = double.Parse(Txtbuy.Text, System.Globalization.CultureInfo.InvariantCulture);
        double btcamounttobuy = double.Parse(Txtbuy.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);


        string btcliveprice = getbtcliveprice.DoWork();

        double amounttobuy = buybtc.DoWork(btcamounttobuy, btcliveprice);

        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));



        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();

        if (amounttobuy < currentusdbalance && amounttobuy > 0)
        {
            updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, -amounttobuy);
        }


        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));


        double additionalbtc = double.Parse(Txtbuy.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

        if (amounttobuy < currentusdbalance && amounttobuy > 0)
        {
            updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, additionalbtc);

        }

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];
        usd_balance.Text = userData["usd_balance"];

        
        Txtbuy.Text = null;
        txt3.Text = null;

    }

    protected void SellBitcoin_Click(object sender, EventArgs e)
    {

        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();
        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        BuyBtcReference.BuyBtcClient buybtc = new BuyBtcReference.BuyBtcClient();

        String userId = Request.QueryString["userId"];

        //double btcamounttosell = double.Parse(Txtsell.Text, System.Globalization.CultureInfo.InvariantCulture);
        double btcamounttosell = double.Parse(Txtsell.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);


        string btcliveprice = getbtcliveprice.DoWork();

        double amounttosell = buybtc.DoWork(btcamounttosell, btcliveprice);

        GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();

        double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));

        if (currentbtcbalance > 0 && btcamounttosell > 0)
        {
            updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, amounttosell);
        }


        double additionalbtc = double.Parse(Txtsell.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

        if (currentbtcbalance > 0 && btcamounttosell > 0)
        {
            updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, -additionalbtc);
        }

        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();
        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];
        usd_balance.Text = userData["usd_balance"];

        Txtsell.Text = null;
        Txt4.Text = null;
    }

    protected void TxtBuy_TextChanged(object sender, EventArgs e)
    {

        GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();

        string btcprice = getbtcliveprice.DoWork();
        
        double currentbtcprice;
        try
        {
             currentbtcprice = double.Parse(btcprice.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cannot Get btc Price!!');", true);
             currentbtcprice = 0;
        }

        if ((!string.IsNullOrEmpty(Txtbuy.Text)))
        {
            double data2 = double.Parse(Txtbuy.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
            double data3 = (currentbtcprice * data2);
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
        double currentbtcprice;

        try
        {
            currentbtcprice = double.Parse(btcprice, System.Globalization.CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cannot Get btc Price!!');", true);
            currentbtcprice = 0;
        }

        if ((!string.IsNullOrEmpty(Txtsell.Text)))
        {
            double data2 = double.Parse(Txtsell.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
            double data3 = (currentbtcprice * data2);
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


    protected void WithdrawBtc_Click(object sender, EventArgs e)
    {
        String userId = Request.QueryString["userId"];

        GetBtcBalanceReference.GetBtcBalanceClient getbtcnbalance = new GetBtcBalanceReference.GetBtcBalanceClient();
        UpdateBtcBalanceReference.UpdateBtcBalanceClient updatebtcbalance = new UpdateBtcBalanceReference.UpdateBtcBalanceClient();
        GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();

        double currentbtcbalance = getbtcnbalance.GetCurrentBtcBalance(Int32.Parse(userId));

        //double additionalbtc = double.Parse(textbox3.Text, System.Globalization.CultureInfo.InvariantCulture);
        double additionalbtc = double.Parse(textbox3.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

        if (additionalbtc < 0 || additionalbtc > currentbtcbalance)
        {
            additionalbtc = 0;
        }

        updatebtcbalance.UpdateCurrentBtcBalance(userId, currentbtcbalance, -additionalbtc);

        Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
        bitcoins_balance.Text = userData["bitcoins_balance"];

        textbox3.Text = null;
    }

    protected void WithdrawUsd_Click(object sender, EventArgs e)
    {
        {
            String userId = Request.QueryString["userId"];

            GetUsdBalanceReference.GetUsdBalanceClient getusdbalance = new GetUsdBalanceReference.GetUsdBalanceClient();
            UpdateUsdBalanceReference.UpdateUsdBalanceClient updateusdbalance = new UpdateUsdBalanceReference.UpdateUsdBalanceClient();
            GetUserInfoReference.GetUserInfoClient getuserinfo = new GetUserInfoReference.GetUserInfoClient();


            double currentusdbalance = getusdbalance.GetCurrentUsdBalance(Int32.Parse(userId));

            //double additionalusd = double.Parse(textbox1.Text, System.Globalization.CultureInfo.InvariantCulture);
            double additionalusd = double.Parse(textbox1.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);


            if (additionalusd < 0 || additionalusd > currentusdbalance)
            {
                additionalusd = 0;
            }

            updateusdbalance.UpdateCurrentUsdBalance(userId, currentusdbalance, -additionalusd);

            Dictionary<string, string> userData = getuserinfo.GetUserInformation(Int32.Parse(userId));
            usd_balance.Text = userData["usd_balance"];

            textbox1.Text = null;
        }
    }
}