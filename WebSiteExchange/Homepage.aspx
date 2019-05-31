<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

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
</head>

<body>
  <!--Navigation bar-->
  <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
      <div class="navbar-header">
        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
        </button>
      <a href="#banner"><img src="../img/logo.png" height="80px" width="150px" align="left"/></a>
      <!-- <a class="navbar-brand" href="index.html">Men<span>tor</span></a> -->
      </div>

     <form id="form1" runat="server">

      <div class="collapse navbar-collapse" id="myNavbar">
        <ul class="nav navbar-nav navbar-right">
            <li><a href="#pricing">Live Bitcoin Price</a></li>
            <li><a href="#quotes">Quotes</a></li>
          <li class="btn-trial"><a><asp:Button class="navButton" ID="Button1" runat="server" Text="Login" OnClick="login_home_Click" /></a></li>
          <li class="btn-trial"><a><asp:Button class="navButton" ID="Button2" runat="server" Text="Register" OnClick="register_home_Click" /></a></li>
        </ul>
      </div>
      </form>

    </div>
  </nav>
  <!--/ Navigation bar-->
  
  <!--Banner-->
  <section id="banner"
    <div class="banner">
    <div class="bg-color">

    <!--
      <div class="container">
        <div class="row">
          
            <div class="banner-text text-center">
            <div class="text-border">
              <h2 class="text-dec">Trust & Quality</h2>
            </div>
            <div class="intro-para text-center quote">
              
              <p class="big-text">Learning Today . . . Leading Tomorrow.</p>
              <p class="small-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Laudantium enim repellat sapiente quos architecto<br>Laudantium enim repellat sapiente quos architecto</p>
              
              <a href="#footer" class="btn get-quote">GET A QUOTE</a>
            </div>

            <a href="#feature" class="mouse-hover">
              <div class="mouse"></div>
            </a>
            </div> 
        </div>
      </div>
        --> 
    </div>
  </div>
      </section>
  <!--/ Banner-->


  <!--Pricing-->
  <section id="pricing" class="section-padding">
    <div class="container">
      <div class="row">
         <br />
        <!-- 
        <div class="header-section text-center">
          <h2>Our Pricing</h2>
          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Exercitationem nesciunt vitae,<br> maiores, magni dolorum aliquam.</p>
          <hr class="bottom-line">
        </div>
        -->
        <div class="col-md-12">
          <div class="price-table">
            <!-- Plan  -->
            <div class="pricing-head">
              <h4>Live Bitcoin Price</h4>
              <span class="fa fa-usd curency"></span> <span class="amount"><asp:Label ID="bitcoin_value" runat="server"></asp:Label></span>
            </div>

            <!-- Plean Detail -->
            <div class="price-in mart-15">
              <span class="btn-bg green btn-block"></span>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!--/ Pricing-->

  <!--Quotes-->
  <section id="quotes" class="section-padding">
    <div class="container">
      <div class="row">
        <div class="header-section text-center">
          <h2>Famous Quotes</h2>
          <hr class="bottom-line">
        </div>
      </div>
    </div>
    <div class="container">
        <div class="col-md-4 col-sm-6 padleft-right">
          <figure class="imghvr-fold-up">
            <img src="img/charlielee.jpg" class="img-responsive">
            <figcaption>
              <h3>Charlie Lee</h3>
              <p>"Cryptocurrency is such a powerful concept that it can almost overturn governments."</p> <i>Litecoin founder</i>
            </figcaption>
            <a href="#"></a>
          </figure>
        </div>
        <div class="col-md-4 col-sm-6 padleft-right">
          <figure class="imghvr-fold-up">
            <img src="img/billgates.jpg" class="img-responsive">
            <figcaption>
              <h3>Bill Gates</h3>
              <p>“The future of money is digital currency.”</p> <i>Microsoft Founder</i>
            </figcaption>
            <a href="#"></a>
          </figure>
        </div>
        <div class="row">
        <div class="col-md-4 col-sm-6 padleft-right">
          <figure class="imghvr-fold-up">
            <img src="img/vitalik.jpg" class="img-responsive">
            <figcaption>
              <h3>Vitalik Buterin</h3>
              <p>"The main advantage of blockchain technology is supposed to be that it's more secure, but new technologies are generally hard for people to trust, and this paradox
                  can't really be avoided."</p> <i>Ethereum Co-Founder</i>
            </figcaption>
            <a href="#"></a>
          </figure>
        </div>
      </div>
    </div>
  </section>
  <!--/ Quotes-->

  <!--Footer-->
  <footer id="footer" class="footer">
    <div class="container text-center">

      <ul class="social-links">
        <li><a href="#link"><i class="fa fa-twitter fa-fw"></i></a></li>
        <li><a href="#link"><i class="fa fa-facebook fa-fw"></i></a></li>
        <li><a href="#link"><i class="fa fa-google-plus fa-fw"></i></a></li>
        <li><a href="#link"><i class="fa fa-linkedin fa-fw"></i></a></li>
      </ul>
      ©2018 <!-- Δικτυοκεντρικά Πληροφοριακά Συστήματα -->
      <div class="credits">
          <p></p>
          <p>Παναγόπουλος Παναγιώτης</p>
          <p>Κελέρης Βασίλης</p>
      </div>
    </div>
  </footer>
  <!--/ Footer-->

  <script src="js/jquery.min.js"></script>
  <script src="js/jquery.easing.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/custom.js"></script>
  <script src="contactform/contactform.js"></script>

</body>
</html>
