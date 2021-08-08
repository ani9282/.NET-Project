<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StartExamforStudent.aspx.cs" Inherits="StartExamforStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width,initial-scale=1">
    <meta name="description" content="multikart">
    <meta name="keywords" content="multikart">
    <meta name="author" content="multikart">
    <link rel="icon" href="../assets/title.jpeg" type="image/x-icon">
    <link rel="shortcut icon" href="../assets/title.jpeg" type="image/x-icon">

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
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Multikart admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities.">
    <meta name="keywords" content="admin template, Multikart admin template, dashboard template, flat admin template, responsive admin template, web app">
    <meta name="author" content="pixelstrap">
      <link rel="icon" href="../assets/images/project logo2.jpg" type="image/x-icon">
    <link rel="shortcut icon" href="../assets/images/project logo2.jpg" type="image/x-icon">

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

    <style>
        Space label { margin-left: 20px; }
        #RadioButton1{margin:20px 20px 0px 20px;}
        #RadioButton2{margin:20px 20px 0px 20px;}
        #RadioButton3{margin:20px 20px 0px 20px;}
        #RadioButton4{margin:20px 20px 0px 20px;}
        #Button1{margin:10px 20px 10px 20px; min-width:150px}
        #Button2{margin:10px 20px 10px 20px; min-width:150px}
        #Button3{margin:10px 20px 10px 20px; min-width:150px}
        #Button4{margin:10px 20px 10px 20px; min-width:150px}
        #Button5{margin:10px 20px 10px 20px; min-width:150px}



    </style>
    <script> 
        var deadline = new Date("<%:Deadline%>").getTime(); 
        var now = new Date("<%:Date%>").getTime();
        var t = deadline - now;
        var x = setInterval(function() { 
           t -= 1000;
        var days = Math.floor(t / (1000 * 60 * 60 * 24)); 
        var hours = Math.floor((t%(1000 * 60 * 60 * 24))/(1000 * 60 * 60)); 
        var minutes = Math.floor((t % (1000 * 60 * 60)) / (1000 * 60)); 
        var seconds = Math.floor((t % (1000 * 60)) / 1000); 

            if (t < 0) { 
                clearInterval(x); 
                document.getElementById("timer").innerHTML = "Expired";
                document.getElementById("Button5").click();
            }
            else {
                $("#timer").html(minutes + " : " + seconds);
            }
        }, 1000);   
    </script>
</head>
<body>
    <div class="page-wrapper">
    <div class="page-body-wrapper">
    <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="theme-card">
    <form id="form1" runat="server" class="theme-form" >
    <div class ="container" runat="server">
        <br /><br />
    <h2 align="center">Online Exam Section </h2>
        <br />
        <div>
            <h2 id="timer" align="right"></h2>
        </div>
       <h3 style="color:#000000">Student Name:<b><%:name%>  <%:fname%>  <%:lname%></b></h3><p id="demo"></p> 
        
        <h3 style="color:#000000">Std:<%:std%></h3>
        <br />
         <div style="margin-left:20%">
        <h4>Question No:  <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>   <asp:Label ID="Label2" runat="server" Font-Bold="true"></asp:Label>  </h4>
        </div>
        <div id="RadioButtons" runat="server" class="radio" style="margin-left:20%">
        <asp:RadioButton Font-Size="Large" ID="RadioButton1" runat="server" GroupName="rbd"/><br />
        <asp:RadioButton Font-Size="Large" ID="RadioButton2" runat="server" GroupName="rbd"/><br />
        <asp:RadioButton Font-Size="Large" ID="RadioButton3" runat="server" GroupName="rbd"/><br />
        <asp:RadioButton Font-Size="Large" ID="RadioButton4" runat="server" GroupName="rbd"/><br />
         </div>
        <br />
        <br />
        <div style="width:100%; margin:auto; text-align:center; justify-content: center; align-items: center">
                <asp:Button ID="Button1" Width="25%" runat="server" Text="Previouse" CssClass="btn btn-info btn-md" OnClick="Button1_Click"/> 
                <asp:Button ID="Button2" Width="25%" runat="server" Text="Next" CssClass="btn btn-info btn-md" OnClick="Button2_Click"/>
                <asp:Button ID="Button5" Width="25%" runat="server" Text="FINISH" CssClass="btn btn-solid" OnClick="Button5_Click" />
        </div>
      <%--These Buttons Are Not Visible --%>
        <asp:Button ID="Button3" Visible="false" Width="15%" runat="server" Text="Submit" CssClass="btn btn-info btn-md" OnClick="Button3_Click"/>
        <asp:Button ID="Button4" Visible="false" Width="15%" runat="server" Text="Exit" CssClass="btn btn-info btn-md" OnClick="Button4_Click"/>

    </div>     
    </form>
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
