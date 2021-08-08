<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subjectmaster.aspx.cs" Inherits="subjectmaster" %>

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
            width: 229px;
        }
    
        .auto-style3 {
            height: 42px;
            width: 229px;
        }
    
        .auto-style4 {
            width: 229px;
            height: 69px;
        }
        .auto-style5 {
            height: 69px;
        }
        .auto-style6 {
            width: 229px;
            height: 44px;
        }
        .auto-style7 {
            height: 44px;
        }
        .auto-style9 {
            height: 42px;
        }
        .auto-style10 {
            height: 38px;
            width: 229px;
        }
        .auto-style11 {
            height: 38px;
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
           <%-- <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>--%>
             <a href="SubjectWiseReport.aspx">Subject Wise Report</a>
             <a href="SemisterMaster.aspx">Semester Master</a>
             <a href="AssiagnSubjectTeacher.aspx">Assign teacher to subject</a>


            <%--<a href="addhelp.aspx">Add Help</a>
            <a href="#.aspx">Add Images</a>
            <a href="#.aspx">Add Videos</a>--%>
            
        </div>
        <a href="index.html">Logout</a>
    </div>

    <div class="content">
      <img src="image/b.jfif" style="height:350px; width:1140px;" />

        <form id="form1" runat="server">
       <table border="2" align="center" width="50%" cellpadding="5" cellspacing="6" style="height: 336px">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="4"><h1><em>Subject Maste</em>r</h1></th>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Subject code</th>
     <td>
         <asp:TextBox ID="txtsubcode" runat="server" Width="200px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style4">Subject Name</th>
     <td class="auto-style5">
         
          <asp:TextBox ID="txtsubname" runat="server" Style="width:99%"></asp:TextBox>
     </td>
     </tr>
           
     <tr>
     <th align="center" class="auto-style6">Class</th>
     <td class="auto-style7">
         
          <asp:DropDownList ID="DropDownList1" runat="server">
              <asp:ListItem>FY</asp:ListItem>
              <asp:ListItem>SY</asp:ListItem>
              <asp:ListItem>TY</asp:ListItem>
          </asp:DropDownList>
     </td>
     </tr>
           
     <tr>
     <th align="center" class="auto-style3">Branch</th>
     <td class="auto-style9">
         
          <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="branchname" DataValueField="branchname">
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [branchmaster]"></asp:SqlDataSource>
     </td>
     </tr>
           
     <tr>
     <th align="center" class="auto-style10">Semester Name</th>
     <td class="auto-style11">
         
          <asp:DropDownList ID="DropDownList3" runat="server">
              <asp:ListItem>Semester 1</asp:ListItem>
              <asp:ListItem>Semester 2</asp:ListItem>
          </asp:DropDownList>
     </td>
     </tr>
           
         <td class="auto-style3">
                <asp:Button ID="btnnew" runat="server" Text="New" 
                    Width="79px" Font-Bold="True" Height="31px" align="center" OnClick="btnnew_Click" BackColor="#FFCCFF" style="font-style: italic"/>
             <td style="width: 131px; height: 42px;">
                <asp:Button ID="btnsave" runat="server" Text="Save" 
                    Width="90px" Font-Bold="True" Height="31px" align="center" OnClick="btnsave_Click" BackColor="#FFCCFF" style="font-style: italic"/>
         <td style="width: 131px; height: 42px;">
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                    Width="83px" Font-Bold="True" Height="31px" align="center" OnClick="btnupdaqte_Click" BackColor="#FFCCFF" style="font-style: italic"/>
         
            
            <td style="width: 203px; height: 42px;">
                <asp:Button ID="btndelete" runat="server" Text="Delete" 
                    Width="79px" Font-Bold="True" Height="31px" align="center" OnClick="btndelete_Click" BackColor="#FFCCFF" style="font-style: italic"  />
            </td>
   


           
     
    </table>
            
            
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="263px" BorderStyle="Solid" style="margin-left: 290px" Width="560px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Subjectcode" HeaderText="Subjectcode" SortExpression="Subjectcode" />
                        <asp:BoundField DataField="Subjectname" HeaderText="Subjectname" SortExpression="Subjectname" />
                         <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class" />
                         <asp:BoundField DataField="Branch" HeaderText="Branch" SortExpression="Branch" />
                         <asp:BoundField DataField="SemesterName" HeaderText="SemesterName" SortExpression="SemesterName" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [subjectMaster1]"></asp:SqlDataSource>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [branchmaster]"></asp:SqlDataSource>
                --%>
            
            </asp:Panel>
            <br />
            <br />
            <br />
            
    </form>

        </div>
    <hr />
    

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