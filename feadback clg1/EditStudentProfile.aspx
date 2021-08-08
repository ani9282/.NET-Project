<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditStudentProfile.aspx.cs" Inherits="EditStudentProfile" Debug="true" %>

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
            padding: 1px 1px;
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
        select
{
height: 25px;
width: 250px;
}
#div1 {
  width: 94%;
  height: 70px;
  padding: 10px;
  border: 1px solid #aaaaaa;
}
    
        .auto-style1 {
            height: 432px;
        }
    
        .auto-style2 {
            font-weight: normal;
        }
    
        </style>
<script>
function allowDrop(ev) {
  ev.preventDefault();
}

function drag(ev) {
  ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
  ev.preventDefault();
  var data = ev.dataTransfer.getData("text");
  ev.target.appendChild(document.getElementById(data));
}
</script>
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
           
           <a href="EditStudentProfile.aspx">Edit Profile</a>
            <%-- <a href="subjectmaster.aspx">Subject Master</a>
            <a href="teachermaster.aspx">Teacher Master</a>
            <a href="studentmaster.aspx">Student Master</a>
           <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>
             <a href="SubjectWiseReport.aspx">Subject Wise Report</a>
              <a href="SemisterMaster.aspx">Semester Master</a>
            <a href="AssiagnSubjectTeacher.aspx">Assign teacher to subject</a>--%>




            <%--<a href="addhelp.aspx">Add Help</a>
            <a href="#.aspx">Add Images</a>
            <a href="#.aspx">Add Videos</a>--%>
            
        </div>
        <a href="index.html">Logout</a>
    </div>

    <div class="content">
      <img src="image/b.jfif" style="height:350px; width:1140px;" />

        <form id="form1" runat="server" class="auto-style1">
      <%--  <table border="2" align="center" width="50%" cellpadding="5" cellspacing="6" style="height: 336px">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="6"><h1>Edit Profile</h1></th>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Student Id</th>
     <td>
         <asp:TextBox ID="TextBox1" runat="server" Width="242px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Student Name</th>
     <td>
         
          <asp:TextBox ID="txtstudentname" runat="server" Style="width:99%"></asp:TextBox>
         <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="Red" ControlToValidate="txtstudentname" ErrorMessage="*"></asp:RequiredFieldValidator>
         </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Mobile No</th>
     <td>
         
          <asp:TextBox ID="txtmobno" runat="server" Style="width:99%"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BackColor="Red" ControlToValidate="txtmobno" ErrorMessage="Mobile number must be ten digit" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Email Id</th>
     <td>
         
          <asp:TextBox ID="TextBox2" runat="server" Width="243px"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" BackColor="Red" ControlToValidate="TextBox2" ErrorMessage="email address must be valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Branch Name</th>
     <td class="auto-style8">
         
          <asp:DropDownList ID="txtbrname" runat="server" DataSourceID="SqlDataSource2" DataTextField="branchname" DataValueField="branchname">
              <asp:ListItem>computer</asp:ListItem>
              <asp:ListItem>auto mobile</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [branchmaster]"></asp:SqlDataSource>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Class</th>
     <td>
         <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem>FY</asp:ListItem>
             <asp:ListItem>SY</asp:ListItem>
             <asp:ListItem>TY</asp:ListItem>
         </asp:DropDownList>
     </td>
     </tr>

           <tr>
     <th align="center" class="auto-style2">User Name</th>
     <td>
         
          <asp:TextBox ID="txtusername" runat="server" Style="width:99%"></asp:TextBox>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Password</th>
     <td>
         
          <asp:TextBox ID="txtpassword" type="password" runat="server" Style="width:99%"></asp:TextBox>
       
     </td>
     </tr>
           
       
            
   


           
     
                <asp:Button ID="Button1" runat="server" Text="Update" />
         
            
            
   


           
     
    </table>--%>
            <table border="2" align="center" width="50%" cellpadding="5" cellspacing="6" style="height: 336px">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="6"><h1 class="auto-style2"><em><strong>Edit Profile</strong></em></h1></th>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Student Id</th>
     <td>
         <asp:TextBox ID="txtstudentid" runat="server" Width="200px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Student Name</th>
     <td>
         
          <asp:TextBox ID="txtstudentname" runat="server" Style="width:99%"></asp:TextBox>
         <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="Red" ControlToValidate="txtstudentname" ErrorMessage="*"></asp:RequiredFieldValidator>
         </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Mobile No</th>
     <td>
         
          <asp:TextBox ID="txtmobno" runat="server" Style="width:99%"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BackColor="Red" ControlToValidate="txtmobno" ErrorMessage="Mobile number must be ten digit" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Email Id</th>
     <td>
         
          <asp:TextBox ID="TextBox1" runat="server" Width="236px"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" BackColor="Red" ControlToValidate="TextBox1" ErrorMessage="email address must be valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Branch Name</th>
     <td class="auto-style8">
         
          <asp:DropDownList ID="txtbrname" runat="server" DataSourceID="SqlDataSource2" DataTextField="branchname" DataValueField="branchname">
              <asp:ListItem>computer</asp:ListItem>
              <asp:ListItem>auto mobile</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [branchmaster]"></asp:SqlDataSource>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Class</th>
     <td>
         <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem>FY</asp:ListItem>
             <asp:ListItem>SY</asp:ListItem>
             <asp:ListItem>TY</asp:ListItem>
         </asp:DropDownList>
     </td>
     </tr>

           <tr>
     <th align="center" class="auto-style2">User Name</th>
     <td>
         
          <asp:TextBox ID="txtusername" runat="server" Style="width:99%"></asp:TextBox>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Password</th>
     <td>
         
          <asp:TextBox ID="txtpassword" type="password" runat="server" Style="width:99%"></asp:TextBox>
          <td><asp:Button ID="btngene" runat="server" Text="Generate password" 
                    Width="132px" Font-Bold="True" Height="31px" align="center" OnClick="btngene_Click" BackColor="Silver" style="font-style: italic"/></td>
    
     </td>
     </tr>
           
         <td class="auto-style3">
                <%--&nbsp;<td style="width: 131px; height: 42px;">
                    &nbsp;<td style="width: 131px; height: 42px;">--%>
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                    Width="97px" Font-Bold="True" Height="31px" align="center" OnClick="btnupdaqte_Click" BackColor="#FFCCFF" style="font-style: italic"/>
         
            
            
   


           
     
    </table>
            
            <br />
            <br />
            <br />
            <div>
            </div>
            
    </form>

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
