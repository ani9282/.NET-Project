<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectExamForStudent.aspx.cs" Inherits="SelectExamForStudent" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Multikart admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities.">
    <meta name="keywords" content="admin template, Multikart admin template, dashboard template, flat admin template, responsive admin template, web app">
    <meta name="author" content="pixelstrap">
    <link rel="icon" href="../assets/Title.jpeg" type="image/x-icon">
    <link rel="shortcut icon" href="../assets/Title.jpeg" type="image/x-icon">
    <title>SPKV Takari</title>

    <!-- Google font-->
    <link href="https://fonts.googleapis.com/css?family=Work+Sans:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

    <!-- Font Awesome-->
    <link rel="stylesheet" type="text/css" href="../assets/css/fontawesome.css">

    <!-- Flag icon-->
    <link rel="stylesheet" type="text/css" href="../assets/css/flag-icon.css">

    <!-- ico-font-->
    <link rel="stylesheet" type="text/css" href="../assets/css/icofont.css">

    <!-- Prism css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/prism.css">

    <!-- Chartist css -->
    <link rel="stylesheet" type="text/css" href="../assets/css/chartist.css">

    <!-- Bootstrap css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.css">

    <!-- App css-->
    <link rel="stylesheet" type="text/css" href="../assets/css/admin.css">
    <script type="text/javascript"> 
        function preventBack() { 
            window.history.forward();  
        } 
          
        setTimeout("preventBack()", 0); 
          
        window.onunload = function () { null }; 
    </script> 
</head>

<body>

<!-- page-wrapper Start-->
<div class="page-wrapper">

   

    <!-- Page Body Start-->
    <div class="page-body-wrapper">

        <!-- Page Sidebar Start-->
        <div class="page-sidebar">
            <div class="main-header-left d-none d-lg-block">
                <div class="logo-wrapper"><a href="#"><img class="blur-up lazyloaded" src="../assets/M.jpeg" alt=""></a></div>
            </div>
            <div class="sidebar custom-scrollbar">
              
                <ul class="sidebar-menu">
                    <li><a class="sidebar-header" href="Dashboard1.aspx"><i data-feather="home"></i><span>Dashboard</span></a></li>
                    <li><a class="sidebar-header" href="#"><i data-feather="box"></i> <span>Master</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li>
                                <a href="#"><i class="fa fa-circle"></i>
                                    <span>Master</span> <i class="fa fa-angle-right pull-right"></i>
                                </a>
                                <ul class="sidebar-submenu">
                                    <li><a href="#"><i class="fa fa-circle"></i>Subject Master</a></li>
                                  
                                    
                                </ul>
                            </li>
                          
                        </ul>
                    </li>
                    <li><a class="sidebar-header" href="#"><i data-feather="dollar-sign"></i><span>Exam Section</span><i class="fa fa-angle-right pull-right"></i></a>
                        <ul class="sidebar-submenu">
                            <li><a href="SelectExamForStudent.aspx?id=<%:RollNo %>""><i class="fa fa-circle"></i>Start Exam</a></li>
                            <li><a href="SelectExamForStudent.aspx?id=<%:RollNo %>&other=<%:Other%>"><i class="fa fa-circle"></i>View Results</a></li>
                            <li><a href="#"><i class="fa fa-circle"></i>Transactions</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <!-- Page Sidebar Ends-->

   

        <div class="page-body" >
    <div class="container">
                    <h2 align="center">Select Exam ID</h2>
                    <br />
                    <div class="theme-card">
                        <form name="form1" runat="server" class="theme-form">
                            <div class="form-row" style=" margin:auto; text-align:center; justify-content: center; align-items: center; max-width:1000px">
                               <%--<div class="col-md-6" style=" margin:auto; text-align:center; justify-content: center; align-items: center">--%>
                                            <asp:DropDownList ID ="DropDownList1" CssClass="form-control" AutoPostBack="true" Height="50px" Width="80%"  runat="server">
                                             </asp:DropDownList>
                                </div>
                             <div class="form-row" style=" margin:auto; text-align:center; justify-content: center; align-items: center; max-width:1000px; margin-top:30px">
                                <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" CssClass="btn btn-info btn-md" Text="Start Exam" />
                                </div>
                            </form>
                        </div>
        </div>
         
           
        </div>

      
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

<!--chartist js-->
<script src="../assets/js/chart/chartist/chartist.js"></script>

<!--chartjs js-->
<script src="../assets/js/chart/chartjs/chart.min.js"></script>

<!-- lazyload js-->
<script src="../assets/js/lazysizes.min.js"></script>

<!--copycode js-->
<script src="../assets/js/prism/prism.min.js"></script>
<script src="../assets/js/clipboard/clipboard.min.js"></script>
<script src="../assets/js/custom-card/custom-card.js"></script>

<!--counter js-->
<script src="../assets/js/counter/jquery.waypoints.min.js"></script>
<script src="../assets/js/counter/jquery.counterup.min.js"></script>
<script src="../assets/js/counter/counter-custom.js"></script>

<!--peity chart js-->
<script src="../assets/js/chart/peity-chart/peity.jquery.js"></script>

<!--sparkline chart js-->
<script src="../assets/js/chart/sparkline/sparkline.js"></script>

<!--Customizer admin-->
<script src="../assets/js/admin-customizer.js"></script>

<!--dashboard custom js-->
<script src="../assets/js/dashboard/default.js"></script>

<!--right sidebar js-->
<script src="../assets/js/chat-menu.js"></script>

<!--height equal js-->
<script src="../assets/js/height-equal.js"></script>

<!-- lazyload js-->
<script src="../assets/js/lazysizes.min.js"></script>

<!--script admin-->
<script src="../assets/js/admin-script.js"></script>

</body>
</html>

