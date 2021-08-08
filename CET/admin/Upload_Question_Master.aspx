<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upload_Question_Master.aspx.cs" Inherits="admin_Upload_Question_Master" %>

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
                                    <li><a href="TeacherRegister.aspx"><i class="fa fa-circle"></i>Teacher Registration</a></li>
                                </ul>
                            </li>
                          
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="#"><i data-feather="dollar-sign"></i><span>Exam Section</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="startexam1.aspx"><i class="fa fa-circle"></i>Start Exam</a></li>
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

        <div class="page-body">

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="page-header">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="page-header-left">
                                <h3>Add Questions
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->

            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="card">
                        <div class="theme-card">
                            <form name="form1" runat="server" class="theme-form">
                                <br />
                            <div class="form-row">
                                <div class="col-md-6" style="text-align:center;" >
                                    <label for="lbl_standard" style="font-size:large">Standard:</label>
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="tb_Standard" CssClass="form-control" Enabled="false" runat="server" Width="80%"></asp:TextBox>
                                    </div>
                                </div>  
                                <br />                              
                            <div class="form-row">
                                <div class="col-md-6" style="text-align:center;">
                                     <label for="lbl_Subject" style="font-size:large">Subject:</label>
                                   </div>
                                <div class="col-md-6">
                                        <asp:TextBox ID="tb_Subject" CssClass="form-control" Enabled="false" runat="server" Width="80%"></asp:TextBox>                                                                                                                      
                                </div>
                              </div>
                                <br />                              
                            <div class="form-row">
                                
                                <div class="col-md-6" style="text-align:center;">
                                                     <label for="lbl_ChapterName" style="font-size:large">Chapter Name:</label>
                                </div>
                                <div class="col-md-6">
                                                     <asp:DropDownList ID="dropdownlist_ChapterName" CssClass="form-control" OnSelectedIndexChanged="dropdownlist_ChapterName_SelectedIndexChanged" Ontextchanged="dropdownlist_ChapterName_OnTextChanged" AutoPostBack="true" runat="server" Width="80%">
                                                     <asp:ListItem>< Select Chapter Name ></asp:ListItem>
                                                     </asp:DropDownList>
                                 </div>
                            </div>
                                <br />
                            <div class="form-row">
                                
                                <div class="col-md-6" style="text-align:center;">
                                                    <label for="lbl_ChapterNo" style="font-size:large">Chapter Number:</label>

                                </div>
                                <div class="col-md-6">
                                                    <asp:TextBox ID="tb_ChapterNo" CssClass="form-control" Width="80%" Enabled="false" Ontextchanged="tb_ChapterNo_OnTextChanged" autopostback="true" runat="server" placeholder="Chapter No"></asp:TextBox>                                                                                                                      
                                </div>
                            </div>
                                <br />
                            <div class="form-row">
                                
                                <div class="col-md-6" style="text-align:center;">
                                                    <label for="lbl_Que_No" style="font-size:large">Question Number:</label>
                                </div>
                                <div class="col-md-6">
                                                    <asp:TextBox ID="tb_Que_No" CssClass="form-control" Width="80%" Enabled="false" runat="server" placeholder="Question No"></asp:TextBox>                                                                                                                      
                                </div>
                            </div>
                                
                                <br />
                                <div class="card" style="background-color:lightblue; width:95%; margin:auto">
                                    <br />
                            <div class="form-row" style="width:90%; margin:auto">
                                                    <asp:TextBox ID="tb_Question_Name"  runat="server" TextMode="MultiLine" placeholder="Enter Question" CssClass="form-control" style="margin-left:0px"></asp:TextBox>                                                                                                                      
                            </div>
                                <br />
                            <div class="form-row" style="width:90%; margin:auto">
                                
                                <div class="col-md-6">
                                                   <asp:TextBox ID="tb_Option_A" runat="server" TextMode="MultiLine" placeholder="Enter Option A" CssClass="form-control" style="margin-left:0px"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                               
                                </div>
                                <div class="col-md-6">
                                                   <asp:TextBox ID="tb_Option_B" runat="server" TextMode="MultiLine" placeholder="Enter option B" CssClass="form-control" style="margin-left:0px"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              

                                </div>
                            </div>
                                <br />
                            <div class="form-row" style="width:90%; margin:auto">
                                
                                <div class="col-md-6">
                                                   <asp:TextBox ID="tb_Option_C" runat="server" TextMode="MultiLine" placeholder="Enter Option C" CssClass="form-control" style="margin-left:0px"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              

                                </div>
                                <div class="col-md-6">
                                                   <asp:TextBox ID="tb_Option_D" runat="server" TextMode="MultiLine" placeholder="Enter Option D" CssClass="form-control" style="margin-left:0px"></asp:TextBox>                                                                                                                                                                                                                                                                                                                                                                                              
                                </div>
                            </div>
                                    <br />
                                    </div>
                           <br />
                            <div class="form-row">
                                
                                <div class="col-md-6" style="text-align:center;">
                                                    <label for="lbl_Correct_Ans" style="font-size:large">Correct Ans:</label>
                                    </div>
                                    <div class="col-md-6">
                                         <asp:TextBox ID="tb_Correct_Ans" runat="server" TextMode="MultiLine" placeholder="Enter Correct Answer" CssClass="form-control" Width="80%"></asp:TextBox>                                                                                                                      
                                    </div>
                                
                            </div>
                                <br />
                                <div class="form-row">
                                
                                <div class="col-md-6" style="text-align:center;">
                                        <label for="lbl_Explaination" style="font-size:large">Explanation:</label>
                                    </div>
                                    <div class="col-md-6">
                                       <asp:TextBox ID="tb_Explaination" runat="server" TextMode="MultiLine" placeholder="Enter Explanation"  CssClass="form-control"  Width="80%"></asp:TextBox>                                                                                                                      

                                    </div>
                                
                            </div>
                                    <br />                
                                        
<%--                                                    <label for="lbl_Que_Name" class="col-xl-3 col-sm-4 mb-0">Question Name:</label>
                                                    
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option A:</label>
                                                   
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option B</label>                                                   
                                                   
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option C</label>                                                   
                                                   
                                                    <label for="lbl_Option" class="col-xl-3 col-sm-4 mb-0">Option D</label>                                                   
                                                   --%>

                            <div style="width:100%; margin:auto; text-align:center; justify-content: center; align-items: center">
                                     <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" onclick="Save_Click" Width="150px" Text="Save" /> 
                            </div>
                                                               

                                    <div class="table-responsive">

                                    <!--<div class="marginleft" style="margin-top: 5%; text-align: left;">-->
                                    <div style="margin-top: 2%; text-align: left;">
                                      <asp:GridView ID="grdView" runat="server" AutoGenerateColumns="False" OnRowCommand="grdView_RowCommand" BackColor="White" ViewStateMode="Enabled" BorderStyle="None"  AllowPaging="True"
    OnPageIndexChanging="OnPageIndexChanging" autopostback="true" PageSize="7" BorderColor="#CC9966" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:TemplateField HeaderText="Standard">
                        <ItemTemplate>
                            <asp:Label ID="lblStd" runat="server" Text='<%#Eval("Standard") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Subject">
                        <ItemTemplate>
                            <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("Subject") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Chapter Number">
                        <ItemTemplate>
                            <asp:Label ID="lblChapterNo" runat="server" Text='<%#Eval("Chapter_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Chapter Name">
                        <ItemTemplate>
                            <asp:Label ID="lblChapterName" runat="server" Text='<%#Eval("Chapter_Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Question Number">
                        <ItemTemplate>
                            <asp:Label ID="lblQuestionNo" runat="server" Text='<%#Eval("Question_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Question Name">
                        <ItemTemplate>
                            <asp:Label ID="lblQuestionName" runat="server" Text='<%#Eval("Question_Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Option A">
                        <ItemTemplate>
                            <asp:Label ID="lblOptionA" runat="server" Text='<%#Eval("Option_A") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Option B">
                        <ItemTemplate>
                            <asp:Label ID="lblOptionB" runat="server" Text='<%#Eval("Option_B") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Option C">
                        <ItemTemplate>
                            <asp:Label ID="lblOptionC" runat="server" Text='<%#Eval("Option_C") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Option D">
                        <ItemTemplate>
                            <asp:Label ID="lblOptionD" runat="server" Text='<%#Eval("Option_D") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Correct Ans">
                        <ItemTemplate>
                            <asp:Label ID="lblCorrectAns" runat="server" Text='<%#Eval("Correct_Ans") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Explanation">
                        <ItemTemplate>
                            <asp:Label ID="lblExplanation" runat="server" Text='<%#Eval("Explanation") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    
                 
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkbtnEdit" CommandName="lnkbtnEdit" CommandArgument='<%#Eval("Standard") + "," + Eval("Subject") + "," + Eval("Chapter_No") + "," + Eval("Chapter_Name") + "," + Eval("Question_No") + "," + Eval("Question_Name") + "," + Eval("Option_A") +"," + Eval("Option_B") + "," + Eval("Option_C") + "," + Eval("Option_D") + "," + Eval("Correct_Ans") + "," + Eval("Explanation")%>' runat="server">Edit</asp:LinkButton>
                            <asp:LinkButton ID="lnkbtnDelete" CommandName="lnkbtnDelete" CommandArgument='<%#Eval("Standard") + "," + Eval("Subject") + "," + Eval("Chapter_No") + "," + Eval("Chapter_Name") + "," + Eval("Question_No")%>' runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                                          <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                          <HeaderStyle BorderStyle="Solid" BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                          <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                          <RowStyle BackColor="White" ForeColor="#330099" />
                                          <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                          <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                          <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                          <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                          <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>

                                </div>
                                    </div>
                                   </form>
                                </div>  
                            </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container-fluid Ends-->
           

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
