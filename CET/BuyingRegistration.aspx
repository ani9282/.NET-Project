<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeFile="BuyingRegistration.aspx.cs" Inherits="BuyingRegistration" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width,initial-scale=1">
    <meta name="description" content="multikart">
    <meta name="keywords" content="multikart">
    <meta name="author" content="multikart">
    <link rel="icon" href="../assets/title.jpeg" type="image/x-icon">
    <link rel="shortcut icon" href="../assets/title.jpeg" type="image/x-icon">
    <title>Maangalya Shopping Mall</title>

    <!--Google font-->
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,900" rel="stylesheet">

    <!-- Icons -->
    <link rel="stylesheet" type="text/css" href="../assets/css/fontawesome.css">

    <!--Slick slider css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/slick.css">
    <link rel="stylesheet" type="text/css" href="../assets/css/slick-theme.css">

    <!-- Animate icon -->
    <link rel="stylesheet" type="text/css" href="../assets/css/animate.css">

    <!-- Themify icon -->
    <link rel="stylesheet" type="text/css" href="../assets/css/themify-icons.css">

    <!-- Bootstrap css -->
    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.css">

    <!-- Theme css -->
    <link rel="stylesheet" type="text/css" href="../assets/css/color1.css" media="screen" id="color">
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        .modalBackground
        {
            background-color: Black;
            filter: alpha(opacity=60);
            opacity: 0.6;
        }
        .modalPopup
        {
            background-color: #FFFFFF;
            width: 300px;
            border: 3px solid #0DA9D0;
            padding: 0;
        }
        .modalPopup .header
        {
            background-color: #2FBDF1;
            height: 30px;
            color: White;
            line-height: 30px;
            text-align: center;
            font-weight: bold;
        }
        .modalPopup .body
        {
            min-height: 50px;
            line-height: 30px;
            text-align: center;
            font-weight: bold;
            margin-bottom: 5px;
        }
    </style>
</head>

<body>


    <!-- header start -->
    <header>
        <div class="mobile-fix-option"></div>
        <div class="top-header">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="header-contact">
                            <ul>
                                <li>Welcome to Maangalya Shopping Mall</li>
                                <li><i class="fa fa-phone" aria-hidden="true"></i>Call Us: 123 - 456 - 7890</li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-6 text-right">
                        <ul class="header-dropdown">
                            <li class="mobile-wishlist"><a href="#"><i class="fa fa-heart" aria-hidden="true"></i></a>
                            </li>
                            <li class="onhover-dropdown mobile-account">
                                <i class="fa fa-user" aria-hidden="true"></i> My Account
                                <ul class="onhover-show-div">
                                    <li>
                                        <a href="Login.aspx" data-lng="en">
                                            Login
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#" data-lng="es">
                                            Logout
                                        </a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="main-menu">
                        <div class="menu-left">
                            <div class="navbar">
                                <a href="javascript:void(0)" onclick="openNav()">
                                    <div class="bar-style"> <i class="fa fa-bars sidebar-bar" aria-hidden="true"></i>
                                    </div>
                                </a>
                                <div id="mySidenav" class="sidenav">
                                    <a href="javascript:void(0)" class="sidebar-overlay" onclick="closeNav()"></a>
                                    <nav>
                                        <div onclick="closeNav()">
                                            <div class="sidebar-back text-left">
                                                <i class="fa fa-angle-left pr-2" aria-hidden="true"></i> Back
                                            </div>
                                        </div>
                                        <!-- Vertical Menu -->
                                        <ul id="sub-menu" class="sm pixelstrap sm-vertical ">
                                            <li><a href="#">clothing</a>
                                                <ul class="mega-menu clothing-menu">
                                                    <li>
                                                        <div class="row m-0">
                                                            <div class="col-xl-4">
                                                                <div class="link-section">
                                                                    <h5>women's fashion</h5>
                                                                    <ul>
                                                                        <li><a href="#">dresses</a></li>
                                                                        <li><a href="#">skirts</a></li>
                                                                        <li><a href="#">westarn wear</a></li>
                                                                        <li><a href="#">ethic wear</a></li>
                                                                        <li><a href="#">sport wear</a></li>
                                                                    </ul>
                                                                    <h5>men's fashion</h5>
                                                                    <ul>
                                                                        <li><a href="#">sports wear</a></li>
                                                                        <li><a href="#">western wear</a></li>
                                                                        <li><a href="#">ethic wear</a></li>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                            <div class="col-xl-4">
                                                                <div class="link-section">
                                                                    <h5>accessories</h5>
                                                                    <ul>
                                                                        <li><a href="#">fashion jewellery</a></li>
                                                                        <li><a href="#">caps and hats</a></li>
                                                                        <li><a href="#">precious jewellery</a></li>
                                                                        <li><a href="#">necklaces</a></li>
                                                                        <li><a href="#">earrings</a></li>
                                                                        <li><a href="#">wrist wear</a></li>
                                                                        <li><a href="#">ties</a></li>
                                                                        <li><a href="#">cufflinks</a></li>
                                                                        <li><a href="#">pockets squares</a></li>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                            <div class="col-xl-4">
                                                                <a href="#" class="mega-menu-banner"><img
                                                                        src="../assets/images/mega-menu/fashion.jpg"
                                                                        alt="" class="img-fluid blur-up lazyload"></a>
                                                            </div>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li><a href="#">bags</a>
                                                <ul>
                                                    <li><a href="#">shopper bags</a></li>
                                                    <li><a href="#">laptop bags</a></li>
                                                    <li><a href="#">clutches</a></li>
                                                    <li><a href="#">purses</a>
                                                        <ul>
                                                            <li><a href="#">purses</a></li>
                                                            <li><a href="#">wallets</a></li>
                                                            <li><a href="#">leathers</a></li>
                                                            <li><a href="#">satchels</a></li>
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li><a href="#">footwear</a>
                                                <ul>
                                                    <li><a href="#">sport shoes</a></li>
                                                    <li><a href="#">formal shoes</a></li>
                                                    <li><a href="#">casual shoes</a></li>
                                                </ul>
                                            </li>
                                            <li><a href="#">watches</a>
                                            </li>
                                            <li><a href="#">Accessories</a>
                                                <ul>
                                                    <li><a href="#">fashion jewellery</a></li>
                                                    <li><a href="#">caps and hats</a></li>
                                                    <li><a href="#">precious jewellery</a></li>
                                                    <li><a href="#">more..</a>
                                                        <ul>
                                                            <li><a href="#">necklaces</a></li>
                                                            <li><a href="#">earrings</a></li>
                                                            <li><a href="#">wrist wear</a></li>
                                                            <li><a href="#">accessories</a>
                                                                <ul>
                                                                    <li><a href="#">ties</a></li>
                                                                    <li><a href="#">cufflinks</a></li>
                                                                    <li><a href="#">pockets squares</a></li>
                                                                    <li><a href="#">helmets</a></li>
                                                                    <li><a href="#">scarves</a></li>
                                                                    <li><a href="#">more...</a>
                                                                        <ul>
                                                                            <li><a href="#">accessory gift sets</a></li>
                                                                            <li><a href="#">travel accessories</a></li>
                                                                            <li><a href="#">phone cases</a></li>
                                                                        </ul>
                                                                    </li>
                                                                </ul>
                                                            </li>
                                                            <li><a href="#">belts & more</a></li>
                                                            <li><a href="#">wearable</a></li>
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li><a href="#">house of design</a>
                                            </li>

                                            <li><a href="#">beauty & personal care</a>
                                                <ul>
                                                    <li><a href="#">makeup</a></li>
                                                    <li><a href="#">skincare</a></li>
                                                    <li><a href="#">premium beaty</a></li>
                                                    <li><a href="#">more</a>
                                                        <ul>
                                                            <li><a href="#">fragrances</a></li>
                                                            <li><a href="#">luxury beauty</a></li>
                                                            <li><a href="#">hair care</a></li>
                                                            <li><a href="#">tools & brushes</a></li>
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li><a href="#">home & decor</a>
                                            </li>
                                            <li><a href="#">kitchen</a>
                                            </li>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                            <div class="brand-logo">
                                <a href="index.html"> <img src="../assets/M.jpeg"
                                        class="img-fluid blur-up lazyload" alt=""></a>
                            </div>
                        </div>
                        <div class="menu-right pull-right">
                            <div>


                                
                                    <nav>
                                        <div class="toggle-nav"><i class="fa fa-bars sidebar-bar"></i></div>
                                        <ul class="sm pixelstrap sm-horizontal">
                                            <li>
                                                <div class="mobile-back text-right">
                                                    Back<i class="fa fa-angle-right pl-2" aria-hidden="true"></i>
                                                </div>
                                            </li>
                                            <li>
                                                <a href="Default.aspx">Home</a>
                                            </li>
                                            <li>
                                                <a href="about-page.html">ABOUT US</a>
                                            </li>
                                            <li>
                                                <a href="#">PRODUCT</a>
                                            </li>
                                           
                                            <li>
                                                <a href="#">BLOG</a>
                                            </li>
                                            <li>
                                                <a href="#">CONTACT US</a>
                                            </li>
                                        </ul>
                                    </nav>
                              
                            </div>
                            <div>
                               
                        </div>
                    </div>
                </div>
            </div>
        </div>
            </div>
    </header>
    <!-- header end -->


    <!-- breadcrumb start -->
    <div class="breadcrumb-section">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <div class="page-title">
                        <h2>create account</h2>
                    </div>
                </div>
                <div class="col-sm-6">
                    <nav aria-label="breadcrumb" class="theme-breadcrumb">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
                            <li class="breadcrumb-item active" aria-current="page">create account</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb End -->


    <!--section start-->
    <section class="register-page section-b-space">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h3>create account</h3>
                    <div class="theme-card">
                        <form runat="server" class="theme-form">
                             <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>
    <cc1:ModalPopupExtender ID="ModalPopupExtender1" BehaviorID="mpe" runat="server"
        PopupControlID="pnlPopup" TargetControlID="lnkDummy" BackgroundCssClass="modalBackground"
        CancelControlID="btnHide">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
        <div class="header">
            Information
        </div>
        <div class="body">
            Registration Successfull Redirecting to Payment
            <br />
            <asp:Button ID="btnHide" runat="server" Text="Close" />
        </div>
    </asp:Panel>   


                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="email">First Name</label>
                                    <input type="text" class="form-control" id="fname" name="fname" placeholder="First Name"
                                        required="">
                                </div>
                                <div class="col-md-6">
                                    <label for="review">Last Name</label>
                                    <input type="text" class="form-control" id="lname" name="lname" placeholder="Last Name"
                                        required="">
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="email">email</label>
                                    <input type="text" class="form-control" id="email" name="email" placeholder="Email" required="">
                                </div>
                                <div class="col-md-6">
                                    <label for="review">Password</label>
                                    <input type="password" class="form-control"  name="password" id="review"
                                        placeholder="Enter your password" required="">
                                </div>
                                
                                </div>
                             <div class="form-row">
                                  <div class="col-md-6">
                                    <label for="email">Phone</label>
                                    <input type="text" class="form-control" id="Phone" name="Phone" placeholder="Phone Number" required="">
                                </div>

                                 </div>
                                <section class="contact-page register-page section-b-space">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <h3>SHIPPING ADDRESS</h3>
                   <div class="theme-form">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="name">flat / plot</label>
                                <input type="text" class="form-control" name="home" id="home" placeholder="company name"
                                    required="" ">
                            </div>
                            <div class="col-md-6">
                                <label for="name">Address *</label>
                                <input type="text" class="form-control" id="address" name="address" placeholder="Address"
                                    required=""" >
                            </div>
                            <div class="col-md-6">
                                <label for="email">Zip Code *</label>
                                <input type="text" class="form-control" id="zipcode" name="zipcode" placeholder="zip-code"
                                    required="" ">
                            </div>
                            <div class="col-md-6 select_input">
                                <label for="review">Country *</label>
                                <select class="form-control" size="1" name="country">
                                    <option value="India">India</option>
                                    <option value="UAE">UAE</option>
                                    <option value="U.K">U.K</option>
                                    <option value="US">US</option>
                                </select>
                            </div>
                            <div class="col-md-6">
                                <label for="review">City *</label>
                                <input type="text" class="form-control" id="city" name="city" placeholder="City" required="" ">
                            </div>
                            <div class="col-md-6">
                                <label for="review">Region/State *</label>
                                <input type="text" class="form-control" id="regionstate" name="state" placeholder="Region/state"
                                    required=""">
                            </div>
                            <div class="col-md-12">
                          <asp:Button ID="Button1" runat="server" CssClass="btn btn-solid" OnClick="Button1_Click"
                                   Text="Create Account"/>
                               
                               
                                  
                            </div>
                        </div>
                   </div>
                </div>
            </div>
        </div>
    </section>
                             
                           
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Section ends-->


    <!-- footer start -->
    <footer class="footer-light">
        <div class="light-layout">
            <div class="container">
                <section class="small-section border-section border-top-0">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="subscribe">
                                <div>
                                    <h4>KNOW IT ALL FIRST!</h4>
                                    <p>Never Miss Anything From Maangalya By Signing Up To Our Newsletter.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <form
                                action="https://pixelstrap.us19.list-manage.com/subscribe/post?u=5a128856334b598b395f1fc9b&amp;id=082f74cbda"
                                class="form-inline subscribe-form auth-form needs-validation" method="post"
                                id="mc-embedded-subscribe-form" name="mc-embedded-subscribe-form" target="_blank">
                                <div class="form-group mx-sm-3">
                                    <input type="text" class="form-control" name="EMAIL" id="mce-EMAIL"
                                        placeholder="Enter your email" required="required">
                                </div>
                                <button type="submit" class="btn btn-solid" id="mc-submit">subscribe</button>
                            </form>
                        </div>
                    </div>
                </section>
            </div>
        </div>
        <section class="section-b-space light-layout">
            <div class="container">
                <div class="row footer-theme partition-f">
                    <div class="col-lg-4 col-md-6">
                        <div class="footer-title footer-mobile-title">
                            <h4>about</h4>
                        </div>
                        <div class="footer-contant">
                            <div class="footer-logo"><img src="../assets/M.jpeg" alt=""></div>
                            <p>For years, Maangalya Shopping Mall has been the household name offering a special range for every occasion. With several stores, it has a wide reach with sprawling showrooms in Warangal, Karimnagar, Siddipet and Hanmakonda.</p>
                            <div class="footer-social">
                                <ul>
                                    <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                                    <li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
                                    <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                                    <li><a href="#"><i class="fa fa-instagram" aria-hidden="true"></i></a></li>
                                    <li><a href="#"><i class="fa fa-rss" aria-hidden="true"></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="col offset-xl-1">
                        <div class="sub-title">
                            <div class="footer-title">
                                <h4>my account</h4>
                            </div>
                            <div class="footer-contant">
                                <ul>
                                    <li><a href="#">mens</a></li>
                                    <li><a href="#">womens</a></li>
                                    <li><a href="#">clothing</a></li>
                                    <li><a href="#">accessories</a></li>
                                    <li><a href="#">featured</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="sub-title">
                            <div class="footer-title">
                                <h4>why we choose</h4>
                            </div>
                            <div class="footer-contant">
                                <ul>
                                    <li><a href="#">shipping & return</a></li>
                                    <li><a href="#">secure shopping</a></li>
                                    <li><a href="#">gallary</a></li>
                                    <li><a href="#">affiliates</a></li>
                                    <li><a href="#">contacts</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="sub-title">
                            <div class="footer-title">
                                <h4>store information</h4>
                            </div>
                            <div class="footer-contant">
                                <ul class="contact-list">
                                    <li><i class="fa fa-map-marker"></i>Maangalya Shopping Mall,
                                    </li>
                                    <li><i class="fa fa-map-marker"></i>Main Road, Madeenaguda,</li>
                                    <li><i class="fa fa-map-marker"></i>Hyderabad.</li>
                                    <li><i class="fa fa-phone"></i>Call: +91 40 2988 5353 / 5454</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="sub-footer">
            <div class="container">
                <div class="row">
                    <div class="col-xl-6 col-md-6 col-sm-12">
                        <div class="footer-end">
                            <p><i class="fa fa-copyright" aria-hidden="true"></i> 2020 Powered By Maangalya Shopping Mall</p>
                        </div>
                    </div>
                  
                </div>
            </div>
        </div>
    </footer>
    <!-- footer end -->



    


    <!-- tap to top start -->
    <div class="tap-top">
        <div><i class="fa fa-angle-double-up"></i></div>
    </div>
    <!-- tap to top end -->


    <!-- latest jquery-->
    <script src="../assets/js/jquery-3.3.1.min.js"></script>

    <!-- menu js-->
    <script src="../assets/js/menu.js"></script>

    <!-- lazyload js-->
    <script src="../assets/js/lazysizes.min.js"></script>

    <!-- popper js-->
    <script src="../assets/js/popper.min.js"></script>

    <!-- slick js-->
    <script src="../assets/js/slick.js"></script>

    <!-- Bootstrap js-->
    <script src="../assets/js/bootstrap.js"></script>

    <!-- Bootstrap Notification js-->
    <script src="../assets/js/bootstrap-notify.min.js"></script>

    <!-- Theme js-->
    <script src="../assets/js/script.js"></script>

    <script>
        function openSearch() {
            document.getElementById("search-overlay").style.display = "block";
        }

        function closeSearch() {
            document.getElementById("search-overlay").style.display = "none";
        }
    </script>
      
</body>

</html>