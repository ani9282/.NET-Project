<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecommandedTest.aspx.cs" Inherits="RecommandedTest" %>

<!DOCTYPE html>

<html lang="en">
<head>
  <head runat="server">
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


  
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title></title>
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
           .auto-style2 {
               font-style: italic;
               font-size: x-large;
           }
           .auto-style3 {
               width: 554px;
           }
           .auto-style4 {
               width: 725px;
           }
           .auto-style5 {
               height: 64px;
           }
           #date {
               width: 262px;
               height: 29px;
               margin-left: 0px;
           }
    </style>
      <style>
          .margin{
              margin-left:400px;
          }
      </style>
</head>
<body style="height: 875px">
  
               
               
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
    <br/> <br /><br /> <br />
       
        <form id="form1" runat="server">
    <div style="height: 600px; width: 1492px; margin-right: 142px;">
           <br />
        <table border="4" align="center" cellpadding="3" cellspacing="1" style="height: 40px; width: 25%;">
     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="4"  class="auto-style5"><h1 class="auto-style2" align="center">Recommanded Test</h1></th>
     </tr>
              <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Ref ID:</label>
                              
            </th>
     <td class="auto-style4">
          
            <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="335px" style="margin-left: 0px"></asp:TextBox >&nbsp;&nbsp;
                   
     </td>
        </tr>   
       
    
     
   <tr align="center">
      <td class="auto-style4" colspan="2">  <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 0px" Text="Search" Width="171px" BackColor="Fuchsia" Height="39px" /></td><br /> <br />
       </tr>
            <br /> <br />
         
          
</table>
        <br /> <br />
          <div class="margin">
             <asp:GridView ID="GridView1" runat="server" ></asp:GridView>  
            </div>
        </div>
            </form>

    <
</body>
</html>
