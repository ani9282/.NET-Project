<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Medicine.aspx.cs" Inherits="Medicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
               width: 618px;
           }
           .auto-style5 {
               height: 64px;
           }
    </style>
</head>
  
<body>
    
      <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
        <a href="DashBoard.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master 
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">
           
             <a href="PatientReg.aspx"> Patient Master</a>
             <a href="typemaster.aspx">Type Master</a>
             <a href="EditP.aspx"> Edit Patient </a>
              <a href="Medicine.aspx"> Medicine Info </a>
             <a href="DoctorReg.aspx"> Doctor Reg </a>
             <a href="PathalogyReg.aspx"> Pathalogy Reg</a>
            
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
    <form id="form1" runat="server">
    <div style="height: 805px; width: 1492px; margin-right: 142px;">
           <br />
        <table border="2" align="center" cellpadding="5" cellspacing="6" style="height: 250px; width: 63%;">
     <tr>
        <th align="center" bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h1 class="auto-style2">Medicine Information</h1></th>
     </tr>
              <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Medicine Id"></asp:Label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="262px" style="margin-left: 130px"></asp:TextBox>
     </td>
            </tr>
         
     <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Medicine Name"></asp:Label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="262px" style="margin-left: 130px"></asp:TextBox>
     </td>
     </tr>
    </table>
    &nbsp;
          &nbsp;
          &nbsp;
        &nbsp;  <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" style="margin-left: 399px; margin-top: 45px;" Width="170px" Height="43px" BackColor="Fuchsia" />
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Height="45px" OnClick="Button2_Click" style="margin-top: 0px" Text="Update" Width="170px" BackColor="Fuchsia" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button3" runat="server" BackColor="Fuchsia" Height="45px" OnClick="Button3_Click" Text="Delete" Width="142px" />
        
    </div>
    </form>
</body>
</html>
