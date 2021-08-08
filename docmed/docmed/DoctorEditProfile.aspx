﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorEditProfile.aspx.cs" Inherits="DoctorEditProfileaspx" %>

<!DOCTYPE html>

<html lang="en">
   <head>
       <title>Registration</title>
        <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


  
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    
    <style>
        body {
  margin: 0;
  padding: 0;
  background-color: #17a2b8;
  height: 100vh;
}
#login .container #login-row #login-column #login-box {
  margin-top: 60px;
  max-width: 600px;
  height: 600px;
  border: 1px solid #9C9C9C;
  background-color: #EAEAEA;
}
#login .container #login-row #login-column #login-box #login-form {
  padding: 20px;
}
#login .container #login-row #login-column #login-box #login-form #register-link {
  margin-top: -85px;
}
.state{
    width:100%;
            height: 32px;
        }
   body {
            margin: 0;
            font-family: "Lato", sans-serif;
        }

        .sidebar {
            margin: 0;
            padding: 0;
            width: 200px;
            background-color: #f1f1f1;
            position: fixed;
            height: 100%;
            overflow: auto;
        }

            .sidebar a, .dropdown-btn {
                display: block;
                color: black;
                padding: 16px;
                text-decoration: none;
                text-align: center;
            }

                .sidebar a.active, .dropdown-btn.active {
                    background-color: #4CAF50;
                    color: white;
                }

                .sidenav a:hover, .dropdown-btn:hover {
                    color: #f1f1f1;
                }

        .active {
            background-color: green;
            color: white;
        }

        .sidebar a:hover:not(.active), .dropdown-btn:hover:not(.active) {
            background-color: #555;
            color: white;
        }

        .dropdown-container {
            display: none;
            background-color: #f1f1f1;
            padding-left: 8px;
        }

        div.content {
            margin-left: 200px;
            padding: 0px 1px;
            height: 700px;
            width: 1037px;
        }

        .fa-caret-down {
            float: right;
            padding-right: 8px;
        }

        @media screen and (max-width: 700px) {
            .sidebar {
                width: 100%;
                height: auto;
                position: relative;
            }

                .sidebar a {
                    float: left;
                }

            div.content {
                margin-left: 0;
            }
        }

        @media screen and (max-width: 400px) {
            .sidebar a {
                text-align: center;
                float: none;
            }
        }

        </style>
   
     </head>
       <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
       <a href="DoctorDashboard.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master 
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">
           
            <a href="PrescriptionDD.aspx">Prescription Master</a>
            <a href="DoctorEditProfile.aspx">Edit Profile </a>
            <a href="PatientRegForDoctor.aspx">Patient Registration </a>
            <a href="PatientHistoryDD.aspx">Patient History </a>
            <a href="PathologyTestResultForDoctor.aspx">Test Result </a>
            
        </div>
        <a href="Logout.aspx">Logout</a>
    </div>
    <body>
<%--                     <div class="content" style="background-image: url('img/department/5.png'); background-size:950px,1000px ;background-repeat: no-repeat">
      --%>

   
    <div id="login">
        <h3 class="text-center text-white pt-5" > Doctor Registration</h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                         <div id="login-box" class="col-md-12">
                        <form id="reg" class="form" runat="server" >
                            <h3 class="text-center text-info">&nbsp;</h3>
                            <div class="form-group">
                                <label for="username" class="text-info"> Name:</label><br>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="password" class="text-info">Address:</label><br>
                                 <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="password" class="text-info">Mobile No:</label><br>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                              
                            <div class="form-group">
                                <label for="password" class="text-info">Email:</label><br>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                              <div class="form-group">
                                <label for="password" class="text-info">Password:</label><br>
                               <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                  </div>

                            <div class="form-group">
                                  <label for="password" class="text-info">Type Of Doctor</label><br>
                             <asp:DropDownList ID = "ddlCustomers" height="40px" runat="server">
                                </asp:DropDownList>
                            </div>
                           
                            <div class="form-group">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Update" CssClass="btn btn-info btn-md" OnClick="Button2_Click"/>
                           

                               
                            
                            </div>
                           
                           <%-- <div id="register-link" class="text-right">
                                <a href="Register.aspx" class="text-info">Register here</a>
                            </div>--%>
                        </form>
                    </div>
      


   </div>
                </div>
          </div>
       
   
          <script src="~/Scripts/jquery-1.10.2.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script>
/* Loop through all dropdown buttons to toggle between hiding and showing its dropdown content - This allows the user to have multiple dropdowns without any conflict */
var dropdown = document.getElementsByClassName("dropdown-btn");
var i;

for (i = 0; i < dropdown.length; i++) {
  dropdown[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var dropdownContent = this.nextElementSibling;
    if (dropdownContent.style.display === "block") {
      dropdownContent.style.display = "none";
    } else {
      dropdownContent.style.display = "block";
    }
  });
}
    </script>

    </body>
</html>
