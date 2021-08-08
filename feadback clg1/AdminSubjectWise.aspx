<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminSubjectWise.aspx.cs" Inherits="AdminSubjectWise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>


  
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
            width: 256px;
        }
    
        .auto-style3 {
            width: 256px;
            height: 71px;
        }
        .auto-style4 {
            height: 71px;
        }
    
        .auto-style6 {
            height: 17px;
            }
    
        .auto-style9 {
            height: 332px;
            width: 57%;
        }
    
        .auto-style10 {
            width: 295px;
            height: 71px;
        }
    
        .auto-style11 {
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
           
           <%--<a href="branchmaster.aspx">Add branchmaster</a>
             <a href="subjectmaster.aspx">Subject Master</a>
            <a href="teachermaster.aspx">Teacher Master</a>
            <a href="studentmaster.aspx">Student Master</a>
            <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>--%>
             <a href="SubjectWiseReport.aspx">Subject Wise Report</a>
            <%-- <a href="AssiagnSubjectTeacher.aspx">Assign teacher to subject</a>--%>
       
           <%-- <a href="addhelp.aspx"></a>
            <a href="#.aspx">Add Images</a>
            <a href="#.aspx">Add Videos</a>
           --%> 
        </div>
        <a href="index.html">Logout</a>
    </div>

    <div class="content">
      <img src="image/b.jfif" style="height:350px; width:1140px;" /><form id="form1" runat="server">
       &nbsp;&nbsp;
       <table border="0" align="center" cellpadding="5" cellspacing="6" class="auto-style9">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="2"><h1 class="auto-style11"><em><strong>Add SubjectWise Report</strong></em></h1></th>
     </tr>
            <tr>
     <th align="center" class="auto-style2">Branch</th>
     <td>
         <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="Branch" DataValueField="Branch">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT [Branch] FROM [TeacherAssgSub]"></asp:SqlDataSource>
         </td>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Class</th>
     <td>
         <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem>FY</asp:ListItem>
             <asp:ListItem>SY</asp:ListItem>
             <asp:ListItem>TY</asp:ListItem>
             <asp:ListItem></asp:ListItem>
         </asp:DropDownList>
         </td>
     </tr>
     <tr>
     <th align="center" class="auto-style3"> Subject</th>
     <td class="auto-style4">
         
         <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="subjectName" DataValueField="subjectName">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT [subjectName] FROM [TeacherAssgSub]"></asp:SqlDataSource>
     </td>
         <td class="auto-style10">
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Get Teacher" BackColor="Silver" style="font-style: italic; font-weight: 700" />
             </td>
         <%--<td>
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
         </td>--%>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Teacher Name</th>
     <td>
         <asp:TextBox ID="TextBox1" runat="server" Width="235px"></asp:TextBox>
               </td>
     </tr>
           <%--                <asp:Button ID="btnsave" runat="server" Text="Save" 
                    Width="70px" Font-Bold="True" Height="31px" align="center" OnClick="btnsave_Click"/>
             
                     
                      --%>
     
     <tr>
     
     <td class="auto-style6" colspan="2">
         
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
         
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Show Report" OnClick="Button1_Click" Height="36px" Width="124px" BackColor="#FFCCFF" style="font-style: italic; font-weight: 700" />
         
         </td>
     </tr>
     
    </table>

            
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            
            <br />
            <%-- <asp:Panel ID="Panel1" runat="server" Height="263px" BorderStyle="Solid" style="margin-left: 290px" Width="560px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="GridView1_PageIndexChanging1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="branchid" HeaderText="branchid" SortExpression="branchid" />
                        <asp:BoundField DataField="branchname" HeaderText="branchname" SortExpression="branchname" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:feedbackcollageConnectionString %>" SelectCommand="SELECT * FROM [branchmaster]"></asp:SqlDataSource>
                
            
            </asp:Panel>--%>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
&nbsp;&nbsp;&nbsp;
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