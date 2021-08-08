<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientR.aspx.cs" Inherits="PatientRaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 294px;
        }
        .auto-style2 {
            font-weight: normal;
        }
        .auto-style3 {
            width: 294px;
            height: 72px;
        }
        .auto-style4 {
            height: 72px;
            width: 357px;
        }
        .auto-style5 {
            width: 357px;
        }
        #date {
            width: 261px;
            height: 29px;
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
           
            <a href="PatientR.aspx">Patient Master</a>
             <a href="typemaster.aspx">Type Master</a>
             <a href="EditP.aspx"> Edit Patient </a>
              <a href="Medicine.aspx"> Medicine Info </a>
             <a href="DoctorReg.aspx"> Doctor Reg </a>
             <a href="PathalogyReg.aspx"> Pathalogy Reg</a>
              <a href="PatientReg.aspx"> Patient Reg</a>
             

            
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
  <table border="2" align="center" cellpadding="5" cellspacing="6" style="height: 541px; width: 51%;">
     <tr>
        <th align="center" bgcolor="Cyan" style="color: black" colspan="4"><h1 class="auto-style2"><em>Patient Register</em></h1></th>
     </tr>
     <tr>
     <th align="center" class="auto-style1">&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Patient ID"></asp:Label>
            </th>
     <td class="auto-style5">
         <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="262px"></asp:TextBox>
     </td>
     

     <th align="center" class="auto-style1">&nbsp;<asp:Label ID="Label2" runat="server" Text="Patient Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
          <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="262px"></asp:TextBox>
     </td>
     </tr>

           
     <tr>
    

          <th align="center" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="DOB"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
         <%-- <asp:TextBox ID="TextBox6" runat="server" Height="29px" Width="262px"></asp:TextBox>--%>
         <input type="date" id="date" name="date" />

         </td>

           <th align="center" class="auto-style1">&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Gender"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         <input id="RadioButton1" type="radio" name="gender" value="RadioButton1" /><labelforlabelfor="RadioButton1">Male</label>   &nbsp;&nbsp;&nbsp;&nbsp;
         <input id="RadioButton2" type="radio" name="gender" value="RadioButton1" /><labelforlabelfor="RadioButton1">Female</label>  
         </td>

     </tr>
           

     <tr>
         <th align="center" class="auto-style1">Address&nbsp;</th>
     <td class="auto-style5">
         
          <asp:TextBox ID="TextBox5" runat="server" Height="29px" Width="262px"></asp:TextBox>
         </td>

     <th align="center" class="auto-style1">&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Contact No"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
          <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="262px"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Phone number" ControlToValidate="TextBox4" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" style="font-size: small; color: #FF0000" ></asp:RegularExpressionValidator> 
         </td>
     
 
     </tr>
      <tr>
          <th align="center" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Blood Group"></asp:Label>
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
         </td>
     
          <th align="center" class="auto-style1">&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Insurance"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;</th>
     <td class="auto-style5">
         
         <%-- <asp:TextBox ID="TextBox7" runat="server" Height="29px" Width="262px"></asp:TextBox>--%>
         <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes" />
         <asp:CheckBox ID="CheckBox2" runat="server" Text="No" />
         </td>

      </tr>
     

        

      
           
         </table>
        <p>
   


           
     
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
     
                <asp:Button ID="btnsave" runat="server" Text="Submit" 
                    Width="221px" Font-Bold="True" Height="48px" align="center" OnClick="btnsave_Click" BackColor="green" style="font-style: italic"/>
              


           
     
        </p>
    </form>
</body>
</html>
