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
    <title>SPKV Takari</title>

    <!-- Google font-->
    <link href="https://fonts.googleapis.com/css?family=Work+Sans:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

    <!-- Font Awesome-->
    <link rel="stylesheet" type="text/css" href="../assets/css/fontawesome.css">

    <!-- Flag icon-->
    <link rel="stylesheet" type="text/css" href="../assets/css/flag-icon.css">

    <!-- jsgrid css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/jsgrid.css">

    <!-- Bootstrap css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.css">

    <!-- App css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/admin.css">
</head>
<body>


<!-- page-wrapper Start-->
<div class="page-wrapper">

    <!-- Page Header Start-->
    <div class="page-main-header">
        <div class="main-header-right row">
            <div class="main-header-left d-lg-none">
                <div class="logo-wrapper"><a href="index.html"><img src="../assets/title.jpeg" alt=""></a></div>
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
                        <div class="media align-items-center"><img class="align-self-center pull-right img-50 rounded-circle" src="../assets/images/dashboard/man.png" alt="header-user">
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
                <div class="logo-wrapper"><a href="index.html"><img src="../assets/M.jpeg" alt=""></a></div>
            </div>
            <div class="sidebar custom-scrollbar">
                
                <ul class="sidebar-menu">
                    <li><a class="sidebar-header" href="Dashboard.aspx"><i data-feather="home"></i><span>Dashboard</span></a></li>
                    <li><a class="sidebar-header" href="#"><i data-feather="box"></i> <span>Products</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a class="sidebar-header" href="#"><i data-feather="box"></i> <span>Master</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            
                               
                                    <li><a href="Category.aspx"><i class="fa fa-circle"></i>Subject Master</a></li>
                                  
                                    <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Chapter Master</a></li>
                                   <li><a href="EditChapter.aspx"><i class="fa fa-circle"></i>Edit Chapter</a></li>
                                    <li><a href="BulkUpload.aspx"><i class="fa fa-circle"></i>Upload Question</a></li>
                                    
                                    <li><a href="StudRegister.aspx"><i class="fa fa-circle"></i>Student Registration</a></li>
                                    <li><a href="TeacherRegister.aspx"><i class="fa fa-circle"></i>Teacher Registration</a></li>
                                
                            
                          
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="#"><i data-feather="dollar-sign"></i><span>Exam Section</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="startexam1.aspx"><i class="fa fa-circle"></i>Create Exam</a></li>
                            <li><a href="SelectExamAdmin.aspx"><i class="fa fa-circle"></i>View Results</a></li>
                            <li><a href="transactions.html"><i class="fa fa-circle"></i>Transactions</a></li>
                        </ul>
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
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/user.png" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Vincent Porter</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/user1.jpg" alt="">
                                    <div class="status-circle away"></div>
                                    <div class="about">
                                        <div class="name">Ain Chavez</div>
                                        <div class="status"> 28 minutes ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/user2.jpg" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Kori Thomas</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/user3.jpg" alt="">
                                    <div class="status-circle online"></div>
                                    <div class="about">
                                        <div class="name">Erica Hughes</div>
                                        <div class="status"> Online</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/man.png" alt="">
                                    <div class="status-circle offline"></div>
                                    <div class="about">
                                        <div class="name">Ginger Johnston</div>
                                        <div class="status"> 2 minutes ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/user5.jpg" alt="">
                                    <div class="status-circle away"></div>
                                    <div class="about">
                                        <div class="name">Prasanth Anand</div>
                                        <div class="status"> 2 hour ago</div>
                                    </div>
                                </li>
                                <li class="clearfix"><img class="rounded-circle user-image" src="../assets/images/dashboard/designer.jpg" alt="">
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

        <div class="page-body">

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="page-header">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="page-header-left">
                                <!--<h3>Category
                                    <small>Maangalya Admin panel</small>
                                </h3>-->
                                <h3>ADD NEW CHAPTER
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->
        <!-- Container-fluid starts-->
          <div class="container">
            <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                                <div class="card">
                                        <div class="theme-card" style="margin-right:10px">                                                                           
                                           <form name="form1" runat="server" class="theme-form" style="margin:auto; margin-left:0px;margin-right:10px; margin-top:15px; width:100%">
                                                 <br />
                                               <div class="form-row">
                                                    <div class="col-md-6" style="text-align:center;">
                                                    <asp:label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger">Standard:</asp:label>
                                                        </div>
                                                    <div class="col-md-6" style="margin-left:0px" >
                                                    <asp:DropDownList ID ="DropDownList2" CssClass="form-control" style=" width:80%" AutoPostBack="true" runat="server" >
                                                    <asp:ListItem>< Select Standard ></asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    </asp:DropDownList>
                                                        </div>  
                                                </div>
                                               <br />
                                                
                                                <div class="form-row">
                                                    <div class="col-md-6" style="text-align:center">
                                                     <asp:label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger">Subject :</asp:label>
                                                         </div>
                                                    <div class="col-md-6" style="text-align:center; margin-left:0px">
                                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" style="width:80%"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" runat ="server">
                                                 
                                                    </asp:DropDownList>  
                                                        </div>                                                                                                                                
                                               </div>
                                               <br />
                                                 <div class="form-row">
                                                    <div class="col-md-6" style="text-align:center">
                                                    <asp:label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" >Chapter Number :</asp:label>
                                                  </div>
                                                    <div class="col-md-6" style="text-align:center; margin-left:0px">
                                                    <asp:TextBox ID ="lbl_ChpterID" class="form-control " style="width:80%" runat="server" type="text" autopostback="true" required="" placeholder="Chapter No"></asp:TextBox>
                                                 </div>
                                               </div>
                                               <br />
                                                 <div class="form-row">
                                                    <div class="col-md-6" style="text-align:center">
                                                    <asp:label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger">Chapter Name :</asp:label>
                                               </div>
                                                    <div class="col-md-6" style="text-align:center; margin-left:0px">
                                                    <input class="form-control" id="validationCustomUsername" style="width:80%" name="ChapterName" type="text" required="" placeholder="Add chapter Name">
                                                </div>
                                               </div>
                                                 <div  style="width:100%; margin:auto; text-align:center; justify-content: center; align-items: center">
                                                     <br />
                                                     <br />
                                                 <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" onclick="Button2_Click" Text="Save" />
                                                     <br />
                                                </div>
                                               <br />
                                    </form>

                                          </div>                                                                                  
                            </div>
                        </div>
                    </div>
              </div>
            </div>
        
            <!-- Container-fluid Ends-->
        </div>
    </div>

        <!-- footer start-->
        <footer class="footer">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-6 footer-copyright">
                        <p class="mb-0">Copyright 2020 @ SPKV Takari</p>
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

<!--Customizer admin-->
<script src="../assets/js/admin-customizer.js"></script>

<!-- Jsgrid js-->
<script src="../assets/js/jsgrid/jsgrid.min.js"></script>
<script src="../assets/js/jsgrid/griddata-manage-product.js"></script>
<script src="../assets/js/jsgrid/jsgrid-manage-product.js"></script>

<!--right sidebar js-->
<script src="../assets/js/chat-menu.js"></script>

<!--script admin-->
<script src="../assets/js/admin-script.js"></script>

</body>
</html>
