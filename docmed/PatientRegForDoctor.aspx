<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientRegForDoctor.aspx.cs" Inherits="PatientRegForDoctor" %>

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
            .center {
 margin: auto;
  width: 50%;
  padding: 0px;
  color:red;
}
        </style>
</head>
<body style="height: 875px">
  
               
               
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
    <div style="height: 894px; text-align: center;">

    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" style="font-weight: 700; font-style: italic; font-size: xx-large; margin-top: 0px;" Text="Patient Registration" Height="44px" Width="467px"></asp:Label>
        
         <div class="center" align="center">

       <asp:Label ID="Label20" runat="server" font-size="15" Text="Label" ></asp:Label><br />
       <asp:Label ID="Label21" runat="server" font-size="15" Text="Label" ></asp:Label>
        </div>
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table border="2" align="center" cellpadding="5" cellspacing="6" style="height: 476px; width: 30%;">
     <tr>
        <th align="center" bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h1 class="auto-style2">Patient Registration</h1></th>
     </tr>
              
    
     </tr>
     <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Reg.Field No"></asp:Label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox2"  name="rfidNo" runat="server" Height="29px" Width="262px" style="margin-left: 0px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style3">&nbsp;<asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style4">
         
          <asp:TextBox ID="TextBox3" name="name" runat="server" Height="29px" Width="262px"></asp:TextBox>
     </td>
     </tr>
           
     <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Email ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style4">
         
          <asp:TextBox ID="TextBox10" runat="server" Height="29px" Width="262px"></asp:TextBox><br />
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid email" ControlToValidate="TextBox10" ValidationExpression="^\S+@\S+$" style="font-size: small; color: #FF0000" ></asp:RegularExpressionValidator> 
         </td>
     </tr>


    <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style4">
         
          <asp:TextBox ID="TextBox11" name="password"  TextMode="password" runat="server" Height="29px" Width="262px"></asp:TextBox>
         
         </td>
     </tr>
            <tr>
            <th align="center" class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label5" runat="server" Text="DOB"></asp:Label>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                 <td class="auto-style4">
                    <input type="date" id="date" name="date" />
                     </td>

           </td></tr>
     <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Contact No" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style4">
         
          &nbsp;<asp:TextBox ID="TextBox5" name="mobile" runat="server" Height="29px" Width="262px"></asp:TextBox><br />
          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Phone number" ControlToValidate="TextBox5" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" style="font-size: small; color: #FF0000" ></asp:RegularExpressionValidator> 
         </td>
     </tr>
           
           
     <tr>
     <th align="center" class="auto-style3">Address&nbsp;</th>
     <td class="auto-style4">
         
          <asp:TextBox ID="TextBox6" name="address" runat="server" Height="29px" Width="262px"></asp:TextBox>
         </td>
     </tr>
      <tr>
          <th align="center" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Blood Group"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
          <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="266px">
              <asp:ListItem>A+</asp:ListItem>
              <asp:ListItem>B+</asp:ListItem>
              <asp:ListItem>AB+</asp:ListItem>
              <asp:ListItem>O+</asp:ListItem>
              <asp:ListItem>A-</asp:ListItem>
              <asp:ListItem>B-</asp:ListItem>
          </asp:DropDownList>
      </tr>
     <%-- <tr>
          <th align="center" class="auto-style1">&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Insurance"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
         <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes" />&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
         <asp:CheckBox ID="CheckBox2" runat="server" Text="No" />
         </td>

      </tr>--%>
      

        <tr>
            <th align="center" class="auto-style1">&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Gender"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
         <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
         </td>
        </tr>

        <tr>
              <th align="center" class="auto-style1">&nbsp;
            <asp:Label ID="Label11" runat="server" Text="Insurance"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
         <%-- <asp:TextBox ID="TextBox7" runat="server" Height="29px" Width="262px"></asp:TextBox>--%>
         <asp:CheckBox ID="CheckBox3" runat="server" Text="Yes" />
         <asp:CheckBox ID="CheckBox4" runat="server" Text="No" />
         </td>
        </tr>
           
         </table>
    
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 0px" Text="Submit" Width="171px" BackColor="Fuchsia" Height="39px" />
        <br />
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

