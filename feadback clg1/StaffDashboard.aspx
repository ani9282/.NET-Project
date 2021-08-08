<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDashboard.aspx.cs" Inherits="StaffDashboard" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


  
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
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
            height: 1000px;
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
<body>
    
        
               
    <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
        <a href="index.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master 
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">
           
           <%-- <a href="branchmaster.aspx">Add Branchmaster</a>
            <a href="subjectmaster.aspx">Subject Master</a>--%>
            <a href="EditProfileStaff.aspx">Edit Profile </a>
           <%-- <a href="studentmaster.aspx">Student Master</a>--%>
             <a href="SubjectWiseReport.aspx">Subjectwise Report</a>
            <%--<a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>
             <a href="addvideo.aspx">Subject Wise Report</a>
            <a href="SemisterMaster.aspx">Semester Master</a>
            <a href="AssiagnSubjectTeacher.aspx">Assign teacher to subject</a>--%>
        </div>
        <a href="index.html">Logout</a>
    </div>

    <div class="content">
      <img src="image/kmg1.jpg" style="height:650px; width:1145px;" />
        <asp:Label ID="Label" runat="server" Text="Welcome"></asp:Label>


    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Welcome"></asp:Label>


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        

    &nbsp;&nbsp;&nbsp;


        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="branch"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="welcome"></asp:Label>

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
