<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewfeedback.aspx.cs" Inherits="viewfeedback" %>

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
    
        .auto-style2 {
            width: 361px;
        }
    
        .auto-style3 {
            width: 300px;
        }
        .auto-style5 {
            height: 695px;
            width: 91%;
        }
    
        .auto-style6 {
            height: 181px;
            font-weight: normal;
        }
    
        .auto-style7 {
            height: 60px;
        }
    
        .auto-style8 {
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
           
           <a href="branchmaster.aspx">Add branchmaster</a>
            <a href="subjectmaster.aspx">Subject Master</a>
            <a href="teachermaster.aspx">Teacher Master</a>
            <a href="studentmaster.aspx">Student Master</a>
            <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>
             <a href="addvideo.aspx">Subject Wise Report</a>



            <%--<a href="addhelp.aspx">Add Help</a>
            <a href="#.aspx">Add Images</a>
            <a href="#.aspx">Add Videos</a>--%>
            
        </div>
        <a href="index.html">Logout</a>
    </div>

    <div class="content">
      <img src="image/b.jfif" style="height:350px; width:1140px;" />
         

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label" runat="server" Text="Welcome"></asp:Label>
         &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
    
        <form id="form1" runat="server">
             
    

&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
             
    

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <table border="2" align="center" cellpadding="5" cellspacing="6" class="auto-style5">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="3" class="auto-style6"><h1 class="auto-style8"><strong><em>View Feedback</em></strong></h1></th>
     </tr>
     <tr>
         
     <th align="center" class="auto-style2">
         <asp:Label ID="Label2" runat="server" Text="Branch"></asp:Label>
         </th>
     <td>
         <asp:TextBox ID="txtbranch" runat="server" Width="200px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style2">
         <asp:Label ID="Label3" runat="server" Text="class"></asp:Label> </th>

        
     <td>
         
          <asp:TextBox ID="txtclass" runat="server" Width="197px"></asp:TextBox>
         <td class="auto-style3">
              <asp:Button ID="Button2" runat="server" Text="Get Subject" OnClick="Button2_Click" BackColor="Silver" Height="30px" style="font-weight: 700; font-style: italic" Width="117px" />
               </td>
         
     </td>
     </tr>
           <tr>

     <th align="center" class="auto-style2">Subject</th>
     <td>
         
          <asp:DropDownList ID="DropDownList1" runat="server">
          </asp:DropDownList>
         <td class="auto-style3">
              <asp:Button ID="Button1" runat="server" Text="Get Teacher" OnClick="Button1_Click2" BackColor="Silver" Height="27px" style="font-style: italic; font-weight: 700" Width="121px" />
               </td>
        </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">semester</th>
     <td>
 
           <asp:TextBox ID="txtsem" runat="server" Width="196px"></asp:TextBox>
 
           <tr>
     <th align="center" class="auto-style2">Teacher name</th>
     <td>
         
          <asp:TextBox ID="txttname" runat="server" Width="197px"></asp:TextBox>
          </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Punctuality &amp; Discipline</th>
     <td class="auto-style8">
         
          <asp:TextBox ID="txtpun" runat="server" Width="201px"></asp:TextBox>
         <td class="auto-style3" style="color: #008080">
              <strong><em>Out Of Five</em></strong><br />
               <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtpun" Display="Dynamic" ErrorMessage="Enter Less than 5" MaximumValue="5" MinimumValue="0" SetFocusOnError="True" Type="Integer" ForeColor="#FF3300">Enter Less than 5</asp:RangeValidator>
               </td>
    
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Domain Knowledge</th>
     <td>
         <asp:TextBox ID="txtdomain" runat="server" Width="203px"></asp:TextBox>
         <td class="auto-style3" style="color: #008080">
              <em><strong>Out Of Five</strong></em><br />
              <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtdomain" ErrorMessage="Enter Less than 5" MaximumValue="5" MinimumValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Type="Integer">Enter Less than 5</asp:RangeValidator>
               </td>
    
     </td>
     </tr>

           <tr>
     <th align="center" class="auto-style2">Presentation skill &amp; Interaction With Students</th>
     <td>
         
          
         <asp:TextBox ID="txtpre" runat="server" Width="207px"></asp:TextBox>
         
          
         <td class="auto-style3" style="color: #008080">
              <em><strong>Out Of Five</strong></em><br />
              <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtpre" ErrorMessage="Enter Less than 5" MaximumValue="5" MinimumValue="0" Display="Dynamic" ForeColor="Red"  SetFocusOnError="True" Type="Integer">Enter Less than 5</asp:RangeValidator>
               </td>
    
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Ability To Resolve Difficulties</th>
     <td>
         
          <asp:TextBox ID="txtability" runat="server" Width="202px"></asp:TextBox>
          <td class="auto-style3" style="color: #008080">
              <strong><em>Out Of Five</em></strong><br />
              <asp:RangeValidator ID="RangeValidator4" runat="server" type="Integer" ControlToValidate="txtability" ErrorMessage="RangeValidator" MaximumValue="5" MinimumValue="0" Display="Dynamic" ForeColor="#FF3300" SetFocusOnError="True">Enter Less than 5</asp:RangeValidator>
               </td>
    
    
     </td>
     </tr>

            <tr>
     <th align="center" class="auto-style2">Effective Use Of Teaching&nbsp; Aids</th>
     <td>
         
          <asp:TextBox ID="txteff" runat="server" Width="198px"></asp:TextBox>
          <td class="auto-style3" style="color: #008080">
              <strong><em>Out Of Five</em></strong><br />
              <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txteff" ErrorMessage="RangeValidator" MaximumValue="5" MinimumValue="0" ForeColor="#FF3300" Display="Dynamic" Type="Integer">Enter Less than 5 </asp:RangeValidator>
                </td>
 
            <tr>
     <th align="center" colspan="3" class="auto-style7">
                <asp:Button ID="btnsave" runat="server" OnClick="Button1_Click" Text="Save" Height="43px" Width="156px" align="center" BackColor="#FFCCFF" style="font-style: italic; font-weight: 700; margin-left: 0px" />
        

                <br />
                <br />
        

                </th>
                
         </table>
            
            
            <br />
            <br />
            <br />
            
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
