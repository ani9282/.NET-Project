<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResultForStudent.aspx.cs" Inherits="ResultForStudent" %>

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
    <style>  
            .container .box {  
                width:90%;
                margin:auto;    
                display:table;  
            }  
            .container .box .box-row {
                display:table-row;
                margin:auto;
                width:50%;
            }  
            .container .box .box-cell {  
                display:table-cell;  
                padding:10px;
                width:50%;
                margin:auto;
            } 
            .container .box .box-cell.box0 { 

                color:white;  
                text-align:justify; 
                width:100px;
            }  
            .container .box .box-cell.box1 { 

                color:white;  
                text-align:justify; 
                width:100px;
            }  
            .container .box .box-cell.box2 {  
                text-align:justify;
                width:100px;
            }  
            .center {
              margin-left: auto;
              margin-right: auto;
              width: 50%;
              margin-top:auto;
              margin:auto;
            }
        @media screen and (max-width: 800px) {
            .container .box .box-cell.box0 {
                display: none;
            }
        }

        </style>
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
                            <li><a href="SelectExamForStudent.aspx"><i class="fa fa-circle"></i>Start Exam</a></li>
                            <li><a href="SelectExamForStudent.aspx?id=<%:RollNo %>&other=<%:Other%>"><i class="fa fa-circle"></i>View Results</a></li>
                            <li><a href="#"><i class="fa fa-circle"></i>Transactions</a></li>
                        </ul>
                    </li>
       
                  
              
                </ul>
            </div>
        </div>
        <!-- Page Sidebar Ends-->

        <div class="page-body">
            <!-- Container-fluid starts-->
            <div class="container-fluid">
                <div class="page-header">

                            
                                <h3 align="center" style="color:black; font-size:44px; margin:auto"><b>RESULT</b>
                                </h3>
                </div>
            </div>
            <!-- Container-fluid Ends-->
            <div class="container-fluid">
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card" style=" margin:auto; max-width:900px">
                            
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="theme-card">
                        <form name="form1" runat="server" class="theme-form">
                            <div class="box">  
                                <div class="box-row">  
                                    <div class="box-cell box0" style="max-width:20px; margin:auto">
                                       <img src="../assets/css/flower1.png" class="center" style="max-width:60px; height:150px;" alt="Flowers in Chania">
                                    </div>
                                    <div class="box-cell box1" style="max-width:50px; margin:auto">
                                        <h4 style="color:#000000">Student Name</h4>
                                        <h4 style="color:#000000">Exam ID</h4>
                                        <h4 style="color:#000000">Roll No</h4>
                                        <h4 style="color:#000000">Std</h4>
                                        <h4 style="color:#000000">Total Questions</h4>
                                        <h4 style="color:#000000">Solved Questions</h4>
                                        <h4 style="color:#000000">Total Marks</h4>
                                        <h4 style="color:#000000">Obtained Marks</h4>
                                    </div>
                                    <div class="box-cell box2" style="max-width:500px; margin:auto">
                                        <h4 style="color:#000000"><b><%:Name %></b></h4>
                                        <h4 style="color:#000000"><b><%:ExamNo %></b></h4>
                                        <h4 style="color:#000000"><b><%:RollNo %></b></h4>
                                        <h4 style="color:#000000"><b><%:Standard %></b></h4>
                                        <h4 style="color:#000000"><b><%:TotalQue %></b></h4>
                                        <h4 style="color:#000000"><b><%:SolvedQue %></b></h4>
                                        <h4 style="color:#000000"><b><%:TotalMarks %></b></h4>
                                        <h4 style="color:#000000"><b><%:ObtainedMarks %></b></h4>

                                        </div>
                                    <div class="box-cell box0" style="max-width:20px; margin:auto">
                                       <img src="../assets/css/flower.png" class="center" style="max-width:60px; height:150px;" alt="Flowers in Chania">
                                    </div>
                                   </div>
                                </div>
                            <div class="card-header">
                                <!--<h5>Products Category</h5>-->
                                <h6 align="center">* IF Any Discrepancies found in Mark List, Please Submit your Application to Respective Department</h6>
                            </div>
                            <div class="form-row" style=" margin:auto; text-align:center; justify-content: center; align-items: center; max-width:1000px;">
                                <!--<h5>Products Category</h5>-->
                                    <asp:Button ID="Button2" Width="25%" runat="server" Text="Check Analysis" CssClass="btn btn-info btn-md" OnClick="Button2_Click"/>
                            </div>
                                
                               
                        </form>
                            </div></div>
                    </div>
                 </div>
                            </div>
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