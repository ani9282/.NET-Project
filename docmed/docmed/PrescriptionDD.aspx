<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrescriptionDD.aspx.cs" Inherits="PrescriptionDDaspx" %>

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
   
</head>
<body>
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
       
  
       
        <form id="form1" runat="server">
    <div style="height: 805px; width: 1492px; margin-right: 142px;">
           <br />
        <table border="4" align="center" cellpadding="3" cellspacing="2" style="height: 50px; width: 57%;">
     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="4" class="auto-style5"><h1 class="auto-style2" align="center">Prescription Master</h1></th>
     </tr>
              <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Ref ID:</label>
                              
            </th>
     <td class="auto-style4">
          
            <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="200px" style="margin-left: 0px"></asp:TextBox >&nbsp;&nbsp;
             <asp:Button ID="Button2" runat="server" Text="Show Data" OnClick="Button1_Click" />
       
        
     </td>
           
       
     
     <th align="center" class="auto-style3">
            <label for="password" class="text-info">Name</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="320px" style="margin-left:0px"></asp:TextBox>
     </td>
    </tr>

     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Email ID:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">&nbsp;&nbsp;
            <label for="password" class="text-info">Password</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="320px" style="margin-left:0px"></asp:TextBox>
     </td>
     </tr>

     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">DOB:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox5" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Mobile</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox6" runat="server" Height="29px" Width="320px" style="margin-left:0px"></asp:TextBox>
     </td>
     </tr>


    <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Address:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox7" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">
            <label for="password" class="text-info">Blood Group</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox8" runat="server" Height="29px" Width="320px" style="margin-left:0px"></asp:TextBox>
     </td>
     </tr>



         <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Gender:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox9" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">
            <label for="password" class="text-info">Insurance</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox10" runat="server" Height="29px" Width="320px" style="margin-left:0px"></asp:TextBox>
     </td>
     </tr>



     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h5 class="auto-style2" align="center">Problem</h5></th>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h5 class="auto-style2" align="center">Medication</h5></th>

     </tr>

    <tr>
         <th align="center" class="auto-style3" rowspan="8" colspan="2">
              <asp:TextBox ID="TextBox11" runat="server" TextMode="MultiLine" Height="270" Width="400"></asp:TextBox> 
         <td class="auto-style4" colspan="2"> </td>
            </th>
        
    </tr>

    <tr>
       <th align="center" class="auto-style3">
             <label for="password" class="text-info">Name:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox12" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
     </tr>

        <tr>
    <th align="center" class="auto-style3">
             <label for="password" class="text-info">Quantity:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox13" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
    
     </tr>

     <tr>
   <th align="center"  bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h5 class="auto-style2" align="center">Directions</h5></th>
           
     </tr>


    <tr>
      <th align="center" class="auto-style3">
             <label for="password" class="text-info">Morning:</label>
            </th>
     <td class="auto-style4">
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                                      <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Breakfast</asp:ListItem>
                                      <asp:ListItem>After Breakfast</asp:ListItem>
                                  </asp:DropDownList>
     </td>
     </tr>

    <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Aftermoon:</label>
            </th>
     <td class="auto-style4">
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                                       <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Lunch</asp:ListItem>
                                      <asp:ListItem>After Lunch</asp:ListItem>
                                  </asp:DropDownList>
     </td>
     </tr>


     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Night:</label>
            </th>
     <td class="auto-style4">
        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                                       <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Dinner</asp:ListItem>
                                      <asp:ListItem>After Dinner</asp:ListItem>
                                  </asp:DropDownList>
     </td>
     </tr>

            <tr>
    
     <td class="auto-style4" colspan="2" align="center">
      <asp:Button ID="Button3" runat="server" Text="ADD" OnClick="Button2_Click" class="btn-solid"/>
     </td>
     </tr>

   
     

             
            

   
   

    
     
           
    <!-- You will not be able to see this text. -->



   
     

     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h5 class="auto-style2" align="center">Allergies</h5></th>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="2" class="auto-style5"><h5 class="auto-style2" align="center">Recommanded Test</h5></th>
     </tr>

    <!--
    <tr height="200px">
        <th align="center" class="auto-style3" colspan="2">
        </th> 
        <th align="center" class="auto-style3" colspan="2"> <asp:TextBox ID="TextBox15" runat="server" TextMode="MultiLine" Height="200" Width="400"></asp:TextBox></th> 


    </tr>
            -->

    
     <tr>
    <th align="center" class="auto-style3">
             <label for="password" class="text-info">substance:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox14" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>

    <th align="center" class="auto-style3" rowspan="3" colspan="2">
            <asp:TextBox ID="TextBox25" runat="server" TextMode="MultiLine" Height="100" Width="420"></asp:TextBox> 
            </th>
    
     </tr>

        <tr>
             <th align="center" class="auto-style3">
             <label for="password" class="text-info">Reaction:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox16" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
            </tr>
      
    <tr>
             <th align="center" class="auto-style3">
             <label for="password" class="text-info">Discription:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox17" runat="server" Height="29px" Width="320px" CssClass="form-control" ></asp:TextBox>
     </td>
            </tr>
      
    
   
   
       
     

   
    

    </table>
        <br />
                <div class="left">
                                <asp:GridView ID="GridView1" runat="server"  class="panel3">
                                </asp:GridView>
                                <br>
                 </div>

        
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;              
     <asp:Button ID="Button1"  runat="server" Text="Save" CssClass="btn btn-info btn-md" OnClick="Button3_Click"/>
                               
                                
                         
                           
                           
    </form>
       



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
