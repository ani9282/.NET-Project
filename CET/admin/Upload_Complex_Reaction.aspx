﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upload_Complex_Reaction.aspx.cs" Inherits="admin_Upload_Complex_Reaction" %>


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
                <div class="logo-wrapper"><a href="index.html"><img class="blur-up lazyloaded" src="../assets/M.jpeg" alt=""></a></div>
            </div>
            <div class="sidebar custom-scrollbar">
              
                <ul class="sidebar-menu">
                    <li><a class="sidebar-header" href="Dashboard.aspx"><i data-feather="home"></i><span>Dashboard</span></a></li>
                    <li><a class="sidebar-header" href="#"><i data-feather="box"></i> <span>Master</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li>
                                <a href="#"><i class="fa fa-circle"></i>
                                    <span>Master</span> <i class="fa fa-angle-right pull-right"></i>
                                </a>
                                <ul class="sidebar-submenu">
                                    <li><a href="Category.aspx"><i class="fa fa-circle"></i>Subject Master</a></li>
                                  
                                    <li><a href="add-product.aspx"><i class="fa fa-circle"></i>Chapter Master</a></li>
                                   <li><a href="EditChapter.aspx"><i class="fa fa-circle"></i>Edit Chapter</a></li>
                                    <li><a href="BulkUpload.aspx"><i class="fa fa-circle"></i>Upload Question</a></li>
                                    
                                    <li><a href="StudRegister.aspx"><i class="fa fa-circle"></i>Student Registration</a></li>
                                    <li><a href="StaffRegister.aspx"><i class="fa fa-circle"></i>Teacher Registration</a></li>
                                </ul>
                            </li>
                          
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href=""><i data-feather="dollar-sign"></i><span>Exam Section</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="Start_Exam.aspx"><i class="fa fa-circle"></i>Start Exam</a></li>
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
                                <li class="breadcrumb-item active">Add Upload Question Master</li>
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
                                               

                                                <div class="Form-group mb-3 row">
                                                    <label for="lbl_standard" class="col-xl-3 col-sm-4 mb-0">Standard:</label>
                                                    <asp:TextBox ID="tb_Standard" class="form-control col-xl-8 col-sm-7" Enabled="false" runat="server"></asp:TextBox>
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>
                                               
                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Subject" class="col-xl-3 col-sm-4 mb-0">Subject:</label>
                                                    <asp:TextBox ID="tb_Subject" class="form-control col-xl-8 col-sm-7" Enabled="false" runat="server"></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_ChapterNo" class="col-xl-3 col-sm-4 mb-0">Chapter Number:</label>
                                                    <asp:TextBox ID="tb_ChapterNo" class="form-control col-xl-8 col-sm-7" Enabled="false" Ontextchanged="tb_ChapterNo_OnTextChanged" autopostback="true" runat="server" placeholder="Chapter No"></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>
                                                
                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_ChapterName" class="col-xl-3 col-sm-4 mb-0">Chapter Name:</label>
                                                     <asp:DropDownList ID="dropdownlist_ChapterName" class="form-control col-xl-8 col-sm-7" OnSelectedIndexChanged="dropdownlist_ChapterName_SelectedIndexChanged" Ontextchanged="dropdownlist_ChapterName_OnTextChanged" AutoPostBack="true" runat="server">
                                                     <asp:ListItem>< Select Chapter Name ></asp:ListItem>
                                                     </asp:DropDownList>                                                                                                                   
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Que_No" class="col-xl-3 col-sm-4 mb-0">Question Number:</label>
                                                    <asp:TextBox ID="tb_Que_No" class="form-control col-xl-8 col-sm-7" Enabled="false" runat="server" placeholder="Question No"></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                 <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Que_Name" class="col-xl-3 col-sm-4 mb-0">Question Name:</label>
                                                    <asp:TextBox ID="tb_Question_Name"  runat="server" TextMode="MultiLine" Width="600px" Height="100px" placeholder="Enter Reaction" ></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>

                                               <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option A:</label>
                                                   <asp:TextBox ID="tb_Option_A"   Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter Option A"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                               
                                                   <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option B</label>                                                   
                                                   <asp:TextBox ID="tb_Option_B"    Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter option B"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              
                                                   <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                 <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option C</label>                                                   
                                                   <asp:TextBox ID="tb_Option_C"    Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter Option C"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              
                                                   <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                 <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option D</label>                                                   
                                                   <asp:TextBox ID="tb_Option_D"   Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter Option D"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              
                                                   <div class="valid-feedback">Looks good!</div>
                                                </div>

                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Correct_Ans" class="col-xl-3 col-sm-4 mb-0">Correct Ans:</label>
                                                    <asp:TextBox ID="tb_Correct_Ans"  Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter Correct Answer"></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
                                                </div>
                                               
                                                <div class="form-group  mb-3 row">                                                                                            
                                                    <label for="lbl_Explaination" class="col-xl-3 col-sm-4 mb-0">Explanation:</label>
                                                    <asp:TextBox ID="tb_Explaination"  Width="600px" Height="100px" runat="server" TextMode="MultiLine" placeholder="Enter Explanation"></asp:TextBox>                                                                                                                      
                                                    <div class="valid-feedback">Looks good!</div>
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
                                                 <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" onclick="Save_Click" Text="Save" /> 
                                                
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
