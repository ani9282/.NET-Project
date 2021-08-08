<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staffregistraion.aspx.cs" Inherits="Staffregistraion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%--<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
    <head>
<style>
body
{
	margin: 0;
	padding: 0;
   /*background-color:thistle;*/
	background: url(image/clg10.jpg) no-repeat;
	background-size: cover;
	font-family: sans-serif;
}
.loginBox
{
	position: absolute;
	top: 5%;
	left: 20%;
	/*transform: translate(-50%,-50%);*/
	width: 700px;
	height: 750px;
	padding: 20px 50px;
	box-sizing: border-box;
	background: rgba(0,0,0,.5);
}

.sanBox
{
	position: absolute;
	top: 50%;
	left: 50%;
	transform: translate(-50%,-50%);
	width: 600px;
	height: 500px;
	padding: 80px 40px;
	box-sizing: border-box;
	background: rgba(0,0,0,.5);
}


.menuBox
{
	position: absolute;
	top: 50%;
	left: 50%;
	transform: translate(-50%,-50%);
	width: 1040px;
	height: 500px;
	padding: 80px 40px;
	box-sizing: border-box;
	background: rgba(0,0,0,.5);
}

.mapBox
{
	position: absolute;
	top: 60%;
	left: 50%;
	transform: translate(-50%,-50%);
	width: 1280px;
	height: 600px;
	padding: 80px 40px;
	box-sizing: border-box;
	background: rgba(0,0,0,.5);
}
.user
{
	width: 100px;
	height: 100px;
	border-radius: 50%;
	overflow: hidden;
	position: absolute;
	top: calc(-100px/2);
	left: calc(50% - 50px);
}
h2
{
	margin: 0;
	padding: 0 0 0px;
	color: #efed40;
	text-align: center;
}
h3
{
	color: #efed40;
}
h1
{
	color: #efed40;
	text-align: center;
}
.loginBox p
{
	margin: 0;
	padding: 0;
	font-weight: bold;
	color: #fff;
}
.loginBox input
{
	margin-bottom: 20px;
}
.loginBox input[type="text"],
.loginBox input[type="password"]
{
	border-bottom: 1px solid #fff;
	/*background: transparent;*/
	outline: none;
	color: Black;
	font-size: 16px;
        border-left-style: none;
        border-left-color: inherit;
        border-left-width: medium;
        border-right-style: none;
        border-right-color: inherit;
        border-right-width: medium;
        border-top-style: none;
        border-top-color: inherit;
        border-top-width: medium;
    }
::placeholder
{
    color:Black;
	/*color: rgba(255,255,255,.5);*/
}
.Gridview{
    color:white;
    margin-left:0px;
}
.loginBox input[type="submit"]
{
	border: none;
	outline: none;
	height: 30px;
	color: #fff;
	font-size: 16px;
	background: #ff267e;
	cursor: pointer;
	border-radius: 20px;
}
.loginBox input[type="submit"]:hover
{
	background: #efed40;
	color: #262626;
}
.loginBox a
{
	color: #fff;
	font-size: 14px;
	font-weight: bold;
	text-decoration: none;
}
ul {
    list-style-type: none;
    margin: 0;
    padding: 10px;
    overflow: hidden;
    background-color: #333;
}

li {
    float: right;
}

li a {
    display: inline-block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: skyblue;
}

.active {
    background-color: red;
.Gridview{
             color:white;
         }
}
    .auto-style1 {
        margin-left: 0px;
        margin-top: 20px;
    }
    .auto-style5 {
        margin-top: 15px;
    }
    .auto-style6 {
        margin-top: 0px;
    }
    .auto-style7 {
        margin-left: 0px;
    }
    .auto-style8 {
        margin-top: 10px;
    }
    .auto-style9 {
        margin-left: 0px;
        margin-top: 9px;
    }
    .auto-style10 {
        margin-top: 6px;
    }
    </style>
        <style>
        body {
             background-image: url("image/clg1.jpg");
             background-repeat: no-repeat;
              background-size: 1600px 800px;
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
                    background-color:black;
                    color: white;
                }

                .sidenav a:hover, .dropdown-btn:hover {
                    color:lightseagreen;
                }

        .active {
            background-color: coral;
            color: white;
        }

        .sidebar a:hover:not(.active), .dropdown-btn:hover:not(.active) {
            background-color:lightseagreen ;
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
    </style>
		<meta charset="utf-8">
		<title>Alumni | Staff Registration</title>

	</head>
	<body>
         <div class="sidebar">

        <a class="active" href="#home">Dashbord</a>
        <a href="home.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master 
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">
           
           <a href="Staffregistraion.aspx">Staff Registration</a>
            <a href="Messagemodule.aspx">Message Module</a>
            <%--<a href="teachermaster.aspx">Teacher Master</a>
            <a href="studentmaster.aspx">Student Master</a>--%>
           <%-- <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>--%>
           <%--  <a href="AdminSubjectWise.aspx">Subject Wise Report</a>
            <a href="SemisterMaster.aspx">Semester Master</a>
            <a href="AssiagnSubjectTeacher.aspx">Assign teacher to subject</a>--%>
        </div>
        <a href="home.aspx">Logout</a>
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
			<div class="loginBox">
			<%--<img src="image/newlogin.png" class="user" alt="ECS">--%>
			<h2>Staff Registration</h2>
                <p>&nbsp;Teacher Id</p>
                &nbsp;<asp:TextBox ID="txtid"  type="text"   runat="server" Width="154px" CssClass="auto-style9"></asp:TextBox>
				<p>Teacher Name</p>
                <asp:TextBox ID="txtname"  type="text"   runat="server" CssClass="auto-style10"></asp:TextBox>
                <p>Branch</p>
				<p>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>CSE</asp:ListItem>
                        <asp:ListItem>Mechnical</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                        <asp:ListItem>Civil</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p>&nbsp;</p>
                <p>Mobile NO</p>
                <p>
				<asp:TextBox ID="txtmobile"  type="text"  runat="server" CssClass="auto-style6"></asp:TextBox> </p>
                <p>&nbsp;Email</p>
                <%--type="password" name="password" placeholder="Enter Password" required>--%>
              <p>
                  <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style8" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
                </p>
                
                <p>Address</p>
                <asp:TextBox ID="txtadd"  type="text"   runat="server" CssClass="auto-style6"></asp:TextBox>
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                 <asp:FileUpload ID="FileUpload1" runat="server" Width="553px" CssClass="auto-style5" />
                 
                 
                <%--<asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" />	--%>
                <asp:Button ID="save" runat="server" Text="save" OnClick="Button1_Click" />	
                 
                 <asp:Button ID="new" runat="server" Text="New" OnClick="Button2_Click" />	
                 
                 <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" CssClass="auto-style1" />		
                 
                <asp:Button ID="Update" runat="server" Text="Update" OnClick="Button3_Click" Width="73px" />	
                <asp:GridView ID="GridView1" runat="server" Width="16px" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Height="92px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="auto-style7">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="teacherid" HeaderText="teacherid" SortExpression="teacherid" />
                        <asp:BoundField DataField="teachername" HeaderText="teachername" SortExpression="teachername" />
                        <asp:BoundField DataField="Branchname" HeaderText="Branchname" SortExpression="Branchname" />
                        <asp:BoundField DataField="mobileno" HeaderText="mobileno" SortExpression="mobileno" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString14 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
               <%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                </div>
			</form>
		
	</body>
</html>

