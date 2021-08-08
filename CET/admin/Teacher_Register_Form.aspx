﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teacher_Register_Form.aspx.cs" Inherits="admin_Teacher_Register_Form" %>

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
        margin-left: 250px;
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
                                    <li><a href="Category.aspx"><i class="fa fa-circle"></i>Subject Master</a></li>                                   
                                    <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Chapter Master</a></li>                            
                                    <li><a href="BulkUpload.aspx"><i class="fa fa-circle"></i>Upload Question</a></li>                                   
                                    <li><a href="Student_Registeration_Form.aspx"><i class="fa fa-circle"></i>Student Registration</a></li>
                                    <li><a href="Teacher_Register_Form.aspx"><i class="fa fa-circle"></i>Teacher Registration</a></li>
                                    <!--<li><a href="category.aspx"><i class="fa fa-circle"></i>Subject Master</a></li>
                                    <li><a href="category-sub.html"><i class="fa fa-circle"></i>Chapter Master</a></li>
                                    <li><a href="product-list.html"><i class="fa fa-circle"></i>Upload Question</a></li>-->
                                    <!--<li><a href="product-detail.html"><i class="fa fa-circle"></i>Product Detail</a></li>
                                    <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Add Product</a></li>-->
                                </ul>
                            </li>
                            <li>
                               <a href="#"><i class="fa fa-circle"></i>
                                    <span>Exam Section</span> <i class="fa fa-angle-right pull-right"></i>
                                </a>
                                <ul class="sidebar-submenu">
                                    <li><a href="Start_Exam.aspx"><i class="fa fa-circle"></i>Generate Question Paper</a></li>
                                    <!--<li><a href="category-digitalsub.html"><i class="fa fa-circle"></i>Sub Category</a></li>
                                    <li><a href="product-listdigital.html"><i class="fa fa-circle"></i>Product List</a></li>
                                    <li><a href="add-digital-product.html"><i class="fa fa-circle"></i>Add Product</a></li>-->
                                </ul>
                            </li>
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
                                <li class="breadcrumb-item active">Teacher Register</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="theme-card">
                            <div class="card-header">
                                <h5>Teacher Register </h5>
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
                                    <div class="col-xl-7" style="font-family: 'Microsoft Sans Serif'; font-size: large; font-weight: bold; color: #000000">
                                       
                              <!--<div class="form-group mb-3 row">-->
                              <div class="form-row">
                                <!--<div class="col-md-3">-->
                                 <!--<div class="col-xl-7">-->
                                 <div class="col-md-3">
                                    <label for="lbl_Stud_ID" class="col-xl-10 col-sm-12 mb-0">Teacher ID</label>                             
                                    <asp:TextBox ID="tb_Teacher_ID" class="col-xl-3 col-sm-4 mb-0" Enabled="false" placeholder="Teacher ID" runat="server"  required="" Font-Size="Medium"></asp:TextBox>
                                    <div class="valid-feedback">Looks good!</div>
                                 </div>
                             </div>
                              <br />
                                
                            <div class="form-group mb-3 row">
                                <div class="col-md-4">
                                    <label for="lbl_F_Name" class="col-xl-12 col-sm-14 mb-0">Teacher First Name </label><br />
                                     <asp:TextBox ID="tb_Teacher_First_Name" placeholder="Teacher First Name" CssClass="form-control digits col-xl-12 col-sm-14" runat="server"  required="" Font-Size="Medium"></asp:TextBox>
                                   
                                    <div class="valid-feedback">Looks good!</div>
                                </div>

                                <div class="col-md-4">
                                    <label for="lbl_M_Name" class="col-xl-12 col-sm-14 mb-0">Teacher Middle Name</label><br />
                                     <asp:TextBox ID="tb_Teacher_Middle_Name" placeholder="Teacher Middle Name" CssClass="form-control digits col-xl-12 col-sm-14" runat="server"  required="" Font-Size="Medium"></asp:TextBox>
                                    <div class="valid-feedback">Looks good!</div>
                                </div>
                                <br />

                                <div class="col-md-4">
                                    <label for="lbl_L_Name" class="col-xl-12 col-sm-14 mb-0">Teacher Last Name</label><br />
                                     <asp:TextBox ID="tb_Teacher_Last_Name" placeholder="Teacher Last Name" CssClass="form-control digits col-xl-12 col-sm-14" runat="server"  required="" Font-Size="Medium"></asp:TextBox>
                                </div>

                            </div>
                            <div class="form-group mb-3 row">
                                <div class="col-md-6">
                                    <label for="lbl_Subject" class="col-xl-10 col-sm-12 mb-0">Subject</label>
                                     <!--<asp:TextBox ID="tb_Standard" class="form-control" placeholder="Standard" runat="server"  required=""></asp:TextBox>-->
                                    <asp:DropDownList ID="DDL_Subject" class="form-control col-xl-15 col-sm-12" placeholder="Subject" runat="server" required="" Font-Size="Medium">
                                        <asp:ListItem>< Select Subject ></asp:ListItem>
                                    </asp:DropDownList>
                                 </div>
                            </div>
                           
                            <div class="form-group mb-3 row">
                                <div class="col-md-6">
                                    <label for="lbl_Mob_No" class="col-xl-10 col-sm-12 mb-0">Mobile Number</label>
                                     <asp:TextBox ID="tb_MoileNo" class="form-control col-xl-15 col-sm-12" placeholder="Mobile Number" runat="server" maxlength="10" required="" Font-Size="Medium"></asp:TextBox>
                                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"   ControlToValidate="tb_MoileNo" ErrorMessage="Enter valid Phone number"  
                                        ValidationExpression="[0-9]{10}" Font-Size="Small"></asp:RegularExpressionValidator>
                                    <div class="valid-feedback">Looks good!</div>                              
                                </div>
                            </div>
                            <div class="form-group mb-3 row">
                                <div class="col-md-6">
                                    <label for="lbl_Address" class="col-xl-10 col-sm-12 mb-0">Address</label>
                                    <asp:TextBox ID="tb_Address" class="form-control col-xl-15 col-sm-12" placeholder="Address" runat="server" required="" Font-Size="Medium"></asp:TextBox>
                                    <div class="valid-feedback">Looks good!</div>
                                </div>
                            </div>
                            <div class="form-group mb-3 row">
                                <asp:Button ID="Btn_Save" runat="server" CssClass="btn btn-primary" OnClick="Save_Click"
                                    Text="Save" />

                            </div>
                                        </div>

                           <div class="table-responsive">

                            <div class="marginleft" style="margin-top: 0%; text-align: left;">

                                <asp:GridView ID="grdView" runat="server" AutoGenerateColumns="False" OnRowCommand="grdView_RowCommand" BackColor="White" BorderStyle="Solid" BorderColor="#999999" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowPaging="True"
    OnPageIndexChanging="OnPageIndexChanging" autopostback="true" PageSize="7">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Teacher ID">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_TeacherID" runat="server" Text='<%#Eval("Teacher_ID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Teacher First Name">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_TeacherFName" runat="server" Text='<%#Eval("Teacher_First_Name") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Teacher Middle Name">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_TeacherMName" runat="server" Text='<%#Eval("Teacher_Middle_Name") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Teacher Last Name">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_TeacherLName" runat="server" Text='<%#Eval("Teacher_Last_Name") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Subject">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_Sub" runat="server" Text='<%#Eval("Subject") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Mobile Number">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMNo" runat="server" Text='<%#Eval("Mobile_No") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Address">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Actions">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkbtnEdit" CommandName="lnkbtnEdit" CommandArgument='<%#Eval("Teacher_ID") + "," + Eval("Teacher_First_Name") + "," + Eval("Teacher_Middle_Name") + "," + Eval("Teacher_Last_Name") + "," + Eval("Subject") + "," + Eval("Mobile_No") + "," + Eval("Address") %>' runat="server">Edit</asp:LinkButton>
                                                <asp:LinkButton ID="lnkbtnDelete" CommandName="lnkbtnDelete" CommandArgument='<%#Eval("Teacher_ID") %>' runat="server">Delete</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BorderStyle="Solid" BackColor="Brown" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
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