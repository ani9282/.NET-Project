<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Laboratorydata.aspx.cs" Inherits="Laboratorydata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Data</title>
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
     <style>
        .topright {
  float: right;
  margin: 25px 50px 75px 100px;
  color:blue;
}
    </style>
      <style type="text/css">  
        .style1  
        {  
            width: 281px;  
        }  
    </style>  
    <style>
          .center{
             margin-left:500px;
          }
    </style>
</head>
<body>
      <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
        <a href="PathalogyDashboard.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">

          
            <a href="RecommandedTest.aspx">Recommanded Test</a>
            <a href="PathologyTest.aspx"> Test</a>
            <a href="Laboratorydata.aspx">Document</a>
             <a href="PathalogyTestResult.aspx">Test Result</a>


        </div>
        <a href="Logout.aspx">Logout</a>
    </div>

     <div class="topright">
       Welcome <%:Session["pName"]%>
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
     <form id="form1" runat="server">  
    <div>  
      <h1>Data Saved</h1>
       
 
      <div class="center">
        <table style="width:100%;">  
            <tr>  
                <td class="style1">  
                     </td>  
                <td>  
                     </td>  
                <td>  
                     </td>  
            </tr>  
            <tr>  
                <td class="style1">  
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="211px" />  
                    </td>  
               
            </tr>  
            <tr>  
                <td class="style1">  
                    <asp:Label ID="Label1" runat="server"></asp:Label>  
                </td>  
                
            </tr>  
            <tr>  
                <td class="style1">  
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />  
                </td>  
                
            </tr>  
        </table>  
      </div>
    </div>  
    </form>  
</body>
</html>
