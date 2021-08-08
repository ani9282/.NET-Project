<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="add-product.aspx.cs"  ValidateRequest="false" Inherits="admin_add_product" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Multikart admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities.">
    <meta name="keywords" content="admin template, Multikart admin template, dashboard template, flat admin template, responsive admin template, web app">
    <meta name="author" content="pixelstrap">
    <link rel="icon" href="../assets/title.jpeg" type="image/x-icon">
    <link rel="shortcut icon" href="../assets/title.jpeg" type="image/x-icon">
    <title>Maangalya Shopping Mall</title>

    <!-- Google font-->
    <link href="https://fonts.googleapis.com/css?family=Work+Sans:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

    <!-- Font Awesome-->
    <link rel="stylesheet" type="text/css" href="../assets/css/fontawesome.css">

    <!-- Flag icon-->
    <link rel="stylesheet" type="text/css" href="../assets/css/flag-icon.css">

    <!-- Bootstrap css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.css">

    <!-- App css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/admin.css">

    

</head>
    <style>
        .marginleft{
        margin-left: 500px;
        }
    </style>
<body>

<form runat="server">
<!-- page-wrapper Start-->
<div class="page-wrapper">

    <!-- Page Header Start-->
    <div class="page-main-header">
        <div class="main-header-right row">
            <div class="main-header-left d-lg-none">
                <div class="logo-wrapper"><a href="index.html"><img class="blur-up lazyloaded" src="../assets/M.jpeg" alt=""></a></div>
            </div>
            <div class="mobile-sidebar">
                <div class="media-body text-right switch-sm">
                    <label class="switch"><a href="#"><i id="sidebar-toggle" data-feather="align-left"></i></a></label>
                </div>
            </div>
            <div class="nav-right col">
                <ul class="nav-menus">
                    <li>
                        <form class="form-inline search-form">
                            <div class="form-group">
                                <input class="form-control-plaintext" type="search" placeholder="Search.."><span class="d-sm-none mobile-search"><i data-feather="search"></i></span>
                            </div>
                        </form>
                    </li>
                    <li><a class="text-dark" href="#!" onclick="javascript:toggleFullScreen()"><i data-feather="maximize-2"></i></a></li>
                    <li class="onhover-dropdown"><a class="txt-dark" href="#">
                        <h6>EN</h6></a>
                        <ul class="language-dropdown onhover-show-div p-20">
                            <li><a href="#" data-lng="en"><i class="flag-icon flag-icon-is"></i> English</a></li>
                            <li><a href="#" data-lng="es"><i class="flag-icon flag-icon-um"></i> Spanish</a></li>
                            <li><a href="#" data-lng="pt"><i class="flag-icon flag-icon-uy"></i> Portuguese</a></li>
                            <li><a href="#" data-lng="fr"><i class="flag-icon flag-icon-nz"></i> French</a></li>
                        </ul>
                    </li>
                    <li class="onhover-dropdown"><i data-feather="bell"></i><span class="badge badge-pill badge-primary pull-right notification-badge">3</span><span class="dot"></span>
                        <ul class="notification-dropdown onhover-show-div p-0">
                            <li>Notification <span class="badge badge-pill badge-primary pull-right">3</span></li>
                            <li>
                                <div class="media">
                                    <div class="media-body">
                                        <h6 class="mt-0"><span><i class="shopping-color" data-feather="shopping-bag"></i></span>Your order ready for Ship..!</h6>
                                        <p class="mb-0">Lorem ipsum dolor sit amet, consectetuer.</p>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="media">
                                    <div class="media-body">
                                        <h6 class="mt-0 txt-success"><span><i class="download-color font-success" data-feather="download"></i></span>Download Complete</h6>
                                        <p class="mb-0">Lorem ipsum dolor sit amet, consectetuer.</p>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="media">
                                    <div class="media-body">
                                        <h6 class="mt-0 txt-danger"><span><i class="alert-color font-danger" data-feather="alert-circle"></i></span>250 MB trash files</h6>
                                        <p class="mb-0">Lorem ipsum dolor sit amet, consectetuer.</p>
                                    </div>
                                </div>
                            </li>
                            <li class="bg-light txt-dark"><a href="#">All</a> notification</li>
                        </ul>
                    </li>
                    <li><a href="#"><i class="right_side_toggle" data-feather="message-square"></i><span class="dot"></span></a></li>
                    <li class="onhover-dropdown">
                        <div class="media align-items-center"><img class="align-self-center pull-right img-50 rounded-circle blur-up lazyloaded" src="../assets/images/dashboard/man.png" alt="header-user">
                            <div class="dotted-animation"><span class="animate-circle"></span><span class="main-circle"></span></div>
                        </div>
                        <ul class="profile-dropdown onhover-show-div p-20">
                            <li><a href="#"><i data-feather="user"></i>Edit Profile</a></li>
                            <li><a href="#"><i data-feather="mail"></i>Inbox</a></li>
                            <li><a href="#"><i data-feather="lock"></i>Lock Screen</a></li>
                            <li><a href="#"><i data-feather="settings"></i>Settings</a></li>
                            <li><a href="#"><i data-feather="log-out"></i>Logout</a></li>
                        </ul>
                    </li>
                </ul>
                <div class="d-lg-none mobile-toggle pull-right"><i data-feather="more-horizontal"></i></div>
            </div>
        </div>
    </div>
 
    <!-- Page Header Ends -->

    <!-- Page Body Start-->
    <div class="page-body-wrapper">

        <!-- Page Sidebar Start-->
        <div class="page-sidebar">
            <div class="main-header-left d-none d-lg-block">
                <div class="logo-wrapper"><a href="index.html"><img  class="blur-up lazyloaded" src="../assets/M.jpeg" alt=""></a></div>
            </div>
            <div class="sidebar custom-scrollbar">
               
                <ul class="sidebar-menu">
                    <li><a class="sidebar-header" href="Dashboard.aspx"><i data-feather="home"></i><span>Dashboard</span></a></li>
                    <li><a class="sidebar-header" href="#"><i data-feather="box"></i> <span>Products</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li>
                                <a href="#"><i class="fa fa-circle"></i>
                                    <span>Master</span> <i class="fa fa-angle-right pull-right"></i>
                                </a>
                                <ul class="sidebar-submenu">
                                  <li><a href="Category.aspx"><i class="fa fa-circle"></i>Category Master</a></li>                                   
                                   <!-- <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Chapter Master</a></li>                            
                                    <li><a href="BulkUpload.aspx"><i class="fa fa-circle"></i>Upload Question</a></li>                                   
                                    <li><a href="Student_Reg.aspx"><i class="fa fa-circle"></i>Student Registration</a></li>
                                    <li><a href="Teacher_Registration.aspx"><i class="fa fa-circle"></i>Teacher Registration</a></li>-->
                                    <!--<li><a href="category.aspx"><i class="fa fa-circle"></i>Subject Master</a></li>
                                    <li><a href="category-sub.html"><i class="fa fa-circle"></i>Chapter Master</a></li>
                                    <li><a href="product-list.html"><i class="fa fa-circle"></i>Upload Question</a></li>-->
                                    <!--<li><a href="product-detail.html"><i class="fa fa-circle"></i>Product Detail</a></li>
                                    <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Add Product</a></li>-->
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-circle"></i>
                                    <span>Digital</span> <i class="fa fa-angle-right pull-right"></i>
                                </a>
                                <ul class="sidebar-submenu">
                                    <!--<li><a href="category-digital.html"><i class="fa fa-circle"></i>Category</a></li>
                                    <li><a href="category-digitalsub.html"><i class="fa fa-circle"></i>Sub Category</a></li>
                                    <li><a href="product-listdigital.html"><i class="fa fa-circle"></i>Product List</a></li>-->
                                    <li><a href="add-digital-product.html"><i class="fa fa-circle"></i>Add Product</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="dollar-sign"></i><span>Sales</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="order.html"><i class="fa fa-circle"></i>Orders</a></li>
                            <li><a href="transactions.html"><i class="fa fa-circle"></i>Transactions</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="tag"></i><span>Coupons</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="CouponList.aspx"><i class="fa fa-circle"></i>List Coupons</a></li>
                            <li><a href="Coupon.aspx"><i class="fa fa-circle"></i>Create Coupons </a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="#"><i data-feather="clipboard"></i><span>Pages</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="pages-list.html"><i class="fa fa-circle"></i>List Page</a></li>
                            <li><a href="page-create.html"><i class="fa fa-circle"></i>Create Page</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="media.html"><i data-feather="camera"></i><span>Media</span></a></li>
                    <li><a class="sidebar-header" href="#"><i data-feather="align-left"></i><span>Menus</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="MenuList.aspx"><i class="fa fa-circle"></i>Menu Lists</a></li>
                            <li><a href="Create-Menu.aspx"><i class="fa fa-circle"></i>Create Menu</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="user-plus"></i><span>Users</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="userlist.aspx"><i class="fa fa-circle"></i>User List</a></li>
                            <li><a href="create-user.aspx"><i class="fa fa-circle"></i>Create User</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="users"></i><span>Vendors</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="list-vendor.html"><i class="fa fa-circle"></i>Vendor List</a></li>
                            <li><a href="create-vendors.html"><i class="fa fa-circle"></i>Create Vendor</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="chrome"></i><span>Localization</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="translations.html"><i class="fa fa-circle"></i>Translations</a></li>
                            <li><a href="currency-rates.html"><i class="fa fa-circle"></i>Currency Rates</a></li>
                            <li><a href="taxes.html"><i class="fa fa-circle"></i>Taxes</a></li>
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="reports.html"><i data-feather="bar-chart"></i><span>Reports</span></a></li>
                    <li><a class="sidebar-header" href=""><i data-feather="settings" ></i><span>Settings</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="profile.html"><i class="fa fa-circle"></i>Profile</a></li>
                        </ul>
                    </li>
<li><a class="sidebar-header" href="invoice.html"><i data-feather="archive"></i><span>Invoice</span></a>
                    </li>
                    <li><a class="sidebar-header" href="Default.aspx"><i data-feather="log-in"></i><span>Login</span></a>
                    </li>
                </ul>
            </div>
        </div>
        <!-- Page Sidebar Ends-->

        <!-- Right sidebar Start-->
        <div class="right-sidebar" id="right_side_bar">
            <div>
                <div class="container p-0">
                    <div class="modal-header p-l-20 p-r-20">
                        <div class="col-sm-8 p-0">
                            <h6 class="modal-title font-weight-bold">FRIEND LIST</h6>
                        </div>
                        <div class="col-sm-4 text-right p-0"><i class="mr-2" data-feather="settings"></i></div>
                    </div>
                </div>
                <div class="friend-list-search mt-0">
                    <input type="text" placeholder="search friend"><i class="fa fa-search"></i>
                </div>
                <div class="p-l-30 p-r-30">
                    <div class="chat-box">
                        <div class="people-list friend-list">
                            <ul class="list">
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/user.png" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Vincent Porter</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/user1.jpg" alt="">
                                    <div class="status-circle away"></div>
                                    <div class="about">
                                        <div class="name">Ain Chavez</div>
                                        <div class="status"> 28 minutes ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/user2.jpg" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Kori Thomas</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/user3.jpg" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Erica Hughes</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/man.png" alt="">
                                    <div class="status-circle offline"></div>
                                    <div class="about">
                                        <div class="name">Ginger Johnston</div>
                                        <div class="status"> 2 minutes ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/user5.jpg" alt="">
                                    <div class="status-circle away"></div>
                                    <div class="about">
                                        <div class="name">Prasanth Anand</div>
                                        <div class="status"> 2 hour ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image blur-up lazyloaded" src="../assets/images/dashboard/designer.jpg" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Hileri Jecno</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Right sidebar Ends-->

        <di class="page-body">

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="page-header">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="page-header-left">
                                <h3>Add Products
                                    <small>Maangalya Admin panel</small>
                                </h3>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <ol class="breadcrumb pull-right">
                                <li class="breadcrumb-item"><a href="index.html"><i data-feather="home"></i></a></li>
                                <li class="breadcrumb-item">Master</li>
                                <li class="breadcrumb-item active">Add Chapter Master</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card">
                            <div class="card-header">
                                <h5> Chapter Master </h5>
                            </div>
                            <div class="card-body">
                                <div class="row product-adding">
                                    <div class="col-xl-5">
                                        <div class="add-product">
                                            <div class="row">
                                                <!--<div class="col-xl-9 xl-50 col-sm-6 col-9">
                                                    
                                                    <asp:Image ID="Image1" runat="server" CssClass="img-fluid image_zoom_1 blur-up lazyloaded" />
                                                </div>
                                                <div class="col-xl-3 xl-50 col-sm-6 col-3">
                                                    <ul class="file-upload-product">
                                                        <li> <asp:FileUpload ID="FileUpload1" runat="server"  /></li>-->
                                                        <li><asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" CssClass="btn btn-primary" CausesValidation="false" UseSubmitBehavior="false"/></li>
                                                        <!--<li><asp:FileUpload ID="FileUpload2" runat="server" /></li>
                                                        <li><asp:FileUpload ID="FileUpload3" runat="server" /></li>
                                                        <li><asp:FileUpload ID="FileUpload4" runat="server" /></li>
                                                        <li><asp:FileUpload ID="FileUpload5" runat="server" /></li>
                                                        <li><asp:FileUpload ID="FileUpload6" runat="server" /></li>
                                                    </ul>
                                                </div>-->
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-7">
                                       
                                            <div class="form">
                                                <!--<div class="form-group mb-3 row">
                                                    <label for="validationCustom01" class="col-xl-3 col-sm-4 mb-0">Title :</label>
                                                    <label for="validationCustom01" class="col-xl-3 col-sm-4 mb-0">ID :</label>
                                                    <input class="form-control col-xl-8 col-sm-7" id="validationCustom01" name="title" type="text" required="">
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>-->
                                                
                                               
                                               <!-- <div class="form-group row">
                                                   <label for="exampleFormControlSelect3" class="col-xl-3 col-sm-4 mb-0">Standard:</label>
                                                    <select class="form-control digits col-xl-8 col-sm-7" name="Standard" id="exampleFormControlSelect3">
                                                        <option>11</option>
                                                        <option>12</option>  
                                                    </select>
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>-->

                                                <div class="Form-group mb-3 row">
                                                    <label for="DropDownList2" class="col-xl-3 col-sm-4 mb-0">Standard:</label>
                                                    <asp:DropDownList ID ="DropDownList2" CssClass="form-control digits col-xl-8 col-sm-7" AutoPostBack="true" runat="server">
                                                    <asp:ListItem>< Select Standard ></asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <!--<div class="form-group mb-3 row">-->
                                                <div class="form-group  mb-3 row">
                                                    <!--<label for="validationCustom02" class="col-xl-3 col-sm-4 mb-0">Discounted Price :</label>
                                                    <label for="" class="col-xl-3 col-sm-4 mb-0">Subject Name :</label>
                                                    <input validationCustom02="form-control col-xl-8 col-sm-7" id="validationCustom11" name="Disprice" oninput="myFunction()" type="text" required="">-->
                                                    
                                                     <label for="exampleFormControlSelect3" class="col-xl-3 col-sm-4 mb-0">Subject :</label>
                                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control digits col-xl-8 col-sm-7" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" runat ="server">
                                                    <asp:ListItem>< Select Subject ></asp:ListItem>
                                                    </asp:DropDownList>                                                                                                                                  
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <div class="form-group mb-3 row">
                                                    <label for="validationCustom02" class="col-xl-3 col-sm-4 mb-0">Chapter Number :</label>
                                                    <asp:TextBox ID ="lbl_ChpterID" class="form-control col-xl-8 col-sm-7" runat="server" type="text" autopostback="true" required=""></asp:TextBox>
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>
                                                <!--<div class="form-group mb-3 row">-->
                                                    <!--<label for="validationCustom02" class="col-xl-3 col-sm-4 mb-0">Discount % :</label>-->
                                                    <!--<label for="validationCustom02" class="col-xl-3 col-sm-4 mb-0">Chapter Number :</label>-->
                                                   <!-- <input class="form-control col-xl-8 col-sm-7" id="validationCustom12" name="Chapter_ID" type="text" required="" >-->
                                                   <!-- <input class="form-control col-xl-8 col-sm-7" id="lbl_ChpterID" name="Chapter_ID" type="text" required="" >-->
                                                    <!--<div class="valid-feedback">Looks good!</div>
                                                </div>-->

                                                <div class="form-group mb-3 row">
                                                    <!--<label for="validationCustomUsername" class="col-xl-3 col-sm-4 mb-0">Product Code :</label>-->
                                                    <label for="validationCustomUsername" class="col-xl-3 col-sm-4 mb-0">Chapter Name :</label>
                                                    <input class="form-control col-xl-8 col-sm-7" id="validationCustomUsername" name="ChapterName" type="text" required="">
                                                    <div class="invalid-feedback offset-sm-4 offset-xl-3">Please choose Valid Code.</div>
                                                </div>
                                            </div>
                                            <!--<div class="form">
                                                <div class="form-group row">
                                                    <label for="exampleFormControlSelect1" class="col-xl-3 col-sm-4 mb-0">Select Size :</label>
                                                    <select class="form-control digits col-xl-8 col-sm-7" name="size" id="exampleFormControlSelect1">
                                                        <option>Small</option>
                                                        <option>Medium</option>
                                                        <option>Large</option>
                                                        <option>Extra Large</option>
                                                    </select>
                                                </div>
                                                <div class="form-group row">
                                                    <label class="col-xl-3 col-sm-4 mb-0">Total Products :</label>
                                                    <fieldset class="qty-box col-xl-9 col-xl-8 col-sm-7 pl-0">
                                                        <div class="input-group">
                                                            <input class="touchspin" name="total" type="text" value="1">
                                                        </div>
                                                    </fieldset>
                                                </div>
                                                <div class="form-group row">
                                                    <label class="col-xl-3 col-sm-4">Add Description :</label>
                                                    <div class="col-xl-8 col-sm-7 pl-0 description-sm">
                                                        <textarea id="editor1" name="editor1" cols="10" rows="4"></textarea>
                                                    </div>
                                                </div>
                                                 <div class="form-group row">
                                                    <label for="exampleFormControlSelect1" class="col-xl-3 col-sm-4 mb-0">Product Type :</label>
                                                    <select class="form-control digits col-xl-8 col-sm-7" name="POD" id="exampleFormControlSelect2">
                                                        <option>New Product</option>
                                                        <option>Featured Product</option>
                                                        <option>Best Sellers</option>
                                                        
                                                    </select>
                                                </div>
                                                  <div class="form-group row">
                                                    <label for="exampleFormControlSelect1" class="col-xl-3 col-sm-4 mb-0">Product Category :</label>
                                                    <select class="form-control digits col-xl-8 col-sm-7" runat="server" name="Category" id="exampleFormControlSelect3">
                                                      
                                                        
                                                    </select>

                                                </div>
                                            </div>-->
                                            <div class="offset-xl-3 offset-sm-4">
                                                 <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" onclick="Button2_Click" Text="Save" />
                                                
                                                <!--<button type="button" class="btn btn-light">Discard</button>-->
                                            </div>
                                        
                                    </div>

                                    <div class="table-responsive">

                                    <div class="marginleft" style="margin-top: 5%; text-align: left;">
            
                                      <asp:GridView ID="grdView" runat="server" AutoGenerateColumns="false" OnRowCommand="grdView_RowCommand" BackColor="White" BorderStyle="Solid">
                <Columns>
                    <asp:TemplateField HeaderText="Standard">
                        <ItemTemplate>
                            <asp:Label ID="lblStd" runat="server" Text='<%#Eval("Standard") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Subject Name">
                        <ItemTemplate>
                            <asp:Label ID="lblSubjectName" runat="server" Text='<%#Eval("Subject") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Chapter Number">
                        <ItemTemplate>
                            <asp:Label ID="lblChapterNo" runat="server" Text='<%#Eval("Chapter_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Chapter Name">
                        <ItemTemplate>
                            <asp:Label ID="lblChapterName" runat="server" Text='<%#Eval("ChapterName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    
                 
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkbtnEdit" CommandName="lnkbtnEdit" CommandArgument='<%#Eval("Standard")+","+ Eval("Subject")+","+ Eval("Chapter_Id")+ ","+ Eval("ChapterName") %>' runat="server">Edit</asp:LinkButton>
                            <asp:LinkButton ID="lnkbtnDelete" CommandName="lnkbtnDelete" CommandArgument='<%#Eval("Standard")+","+ Eval("Subject")+","+ Eval("Chapter_Id") %>' runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                                          <HeaderStyle BorderStyle="Solid" />
            </asp:GridView>

                                </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->

           

      <div>

        <!-- footer start-->
        <footer class="footer">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-6 footer-copyright">
                        <p class="mb-0">Copyright 2020 @ Maangalya Shopping Mall</p>
                    </div>
                    <div class="col-md-6">
                        <p class="pull-right mb-0">Hand crafted & made with<i class="fa fa-heart"></i></p>
                    </div>
                </div>
            </div>
        </footer>
        <!-- footer end-->

    </div>

    </div>

<!-- latest jquery-->
<script src="../assets/js/jquery-3.3.1.min.js"></script>

<!-- Bootstrap js-->
<script src="../assets/js/popper.min.js"></script>
<script src="../assets/js/bootstrap.js"></script>

<!-- feather icon js-->
<script src="../assets/js/icons/feather-icon/feather.min.js"></script>
<script src="../assets/js/icons/feather-icon/feather-icon.js"></script>

<!-- Sidebar jquery-->
<script src="../assets/js/sidebar-menu.js"></script>

<!-- touchspin js-->
<script src="../assets/js/touchspin/vendors.min.js"></script>
<script src="../assets/js/touchspin/touchspin.js"></script>
<script src="../assets/js/touchspin/input-groups.min.js"></script>

<!-- form validation js-->
<script src="../assets/js/dashboard/form-validation-custom.js"></script>

<!-- ckeditor js-->
<script src="../assets/js/editor/ckeditor/ckeditor.js"></script>
<script src="../assets/js/editor/ckeditor/styles.js"></script>
<script src="../assets/js/editor/ckeditor/adapters/jquery.js"></script>
<script src="../assets/js/editor/ckeditor/ckeditor.custom.js"></script>

<!-- Zoom js-->
<script src="../assets/js/jquery.elevatezoom.js"></script>
<script src="../assets/js/zoom-scripts.js"></script>

<!--Customizer admin-->
<script src="../assets/js/admin-customizer.js"></script>

<!-- lazyload js-->
<script src="../assets/js/lazysizes.min.js"></script>

<!--right sidebar js-->
<script src="../assets/js/chat-menu.js"></script>

<!--script admin-->
<script src="../assets/js/admin-script.js"></script>
    </form>

    <script>
function myFunction() {
    var x = document.getElementById("validationCustom11").value;
    var y = document.getElementById("validationCustom02").value;
    var z = ((y - x) / y)*100;
    
    document.getElementById("validationCustom12").value = z;
}
</script>

</body>
</html>