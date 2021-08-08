<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientChangePassword.aspx.cs" Inherits="PatientChangePassword" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">



    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
       <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    
<!------ Include the above in your HEAD tag ---------->
   
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
           
 
#login .container #login-row #login-column #login-box {
  margin-top: 40px;
  max-width: 700px;
  height: auto;
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

    </style>
    <style>
        .panel {
  width: 500px;
  height: 430px;
  padding: 10px;
  border: 1px solid black;
  margin-left:220px;
}
    </style>

    <style>
        .panel2 {
  width: 500px;
  height: 470px;
  padding: 10px;
  border: 1px solid black;
  margin-left:220px;
}
    </style>

     <style>
        .panel3 {
  width: 500px;
  height: auto;
  padding: 10px;
  border: 1px solid black;
  margin-left:220px;
}
    </style>
    <style>
        .center {
  margin-left:430px;
}
    </style>
    <style>
       .left {
  margin-left: 240px;
}
    </style>
    <style>
            .center {
 margin: auto;
  width: 50%;
  padding: 90px;
  color:red;
}
        </style>
   
</head>
<body>
 <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
       <a href="PatientDashboard.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">

            
          
          <a href="PatientProfileForPatient.aspx">Patient History </a>
             <a href="PatientChangePassword.aspx">Change Password </a>
             <a href="PathologyTestResultForPatient.aspx">Test Result </a>
           
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

    
        <div class="center" align="center">

       <asp:Label ID="Label1" runat="server" font-size="20" Text="Label" ></asp:Label>
        </div>
       
        <form id="form1" runat="server">
    <div style="height: 600px; width: 1492px; margin-right: 142px;">
           <br />
        <table border="4" align="center" cellpadding="3" cellspacing="1" style="height: 40px; width: 35%;">
     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="4"  class="auto-style5"><h1 class="auto-style2" align="center">Change Password</h1></th>
     </tr>
              <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Ref ID:</label>
                              
            </th>
     <td class="auto-style4">
          
            <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server" Height="29px" Width="335px" style="margin-left: 0px"></asp:TextBox >&nbsp;&nbsp;
                   
     </td>
        </tr>   
       
     <tr>
     <th align="center" class="auto-style3">
            <label for="password" class="text-info">Name</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="335px" style="margin-left:0px" ReadOnly="true"></asp:TextBox>
     </td>
    </tr>

     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Password:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="335px" TextMode="Password" CssClass="form-control" ></asp:TextBox>  
       
     </td>
         </tr>

     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Confirm Password:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="335px" TextMode="Password" CssClass="form-control" ></asp:TextBox>
     </td>
         </tr>

   <tr align="center">
      <td class="auto-style4" colspan="2">  <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" style="margin-left: 0px" Text="Change Password" Width="171px" BackColor="Fuchsia" Height="39px" /></td>
       </tr>
</table>
        </div>
            </form>
</body>
</html>


