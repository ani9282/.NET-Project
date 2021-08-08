<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumnifeedback.aspx.cs" Inherits="Alumnifeedback" %>

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
	background: url(image/krp3.jpg) no-repeat;
	background-size: cover;
	font-family: sans-serif;
}
.loginBox
{
	position: absolute;
	top: 0%;
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
	margin: 10;
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
    .auto-style2 {
        margin-top: 0px;
    }
    .auto-style4 {
        height: 33px;
        margin-left: 0;
        margin-top: 13;
    }
    .auto-style5 {
        margin-top: 4px;
    }
    .auto-style6 {
        margin-top: 11px;
    }
    .auto-style7 {
        margin-left: 0px;
    }
    .auto-style8 {
        margin-left: 1px;
        margin-top: 12px;
    }
    </style>

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
		<title>Alumni Feedback</title>

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
           
            <%--<a href="Staffregistraion.aspx">Staff Registration</a>--%>
            <a href="Eventinfo.aspx">Event Information</a>
             <a href="Alumnifeedback.aspx">Alumni Feedback</a>
            <%--<a href="teachermaster.aspx">Teacher Master</a>
            <a href="studentmaster.aspx">Student Master</a>--%>
           <%-- <a href="addvideo.aspx">Teacher Wise Report</a>
             <a href="addvideo.aspx">Class Wise Report</a>--%>
             <%--<a href="AdminSubjectWise.aspx">Subject Wise Report</a>
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
			<h2>Alumni Feedback</h2>
              
				<p>Alumni Name</p>
                <asp:TextBox ID="TextBox1"  type="text"   runat="server"></asp:TextBox>
                <p>Branch</p>
                <p>&nbsp;</p>
                
                <%--<asp:TextBox ID="txtbranch"  type="text"   runat="server"></asp:TextBox>--%>
				<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style7">
                    <asp:ListItem>CSE</asp:ListItem>
                    <asp:ListItem>IT</asp:ListItem>
                    <asp:ListItem>Mechnical</asp:ListItem>
                    <asp:ListItem>Civil</asp:ListItem>
                </asp:DropDownList>
                <br />
               <br />

                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="100" Width="500"></asp:TextBox>
                <br /><br />
                 
                <%--<asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" />	--%>
                <asp:Button ID="save" runat="server" Text="Submit" OnClick="Button1_Click" />	
                 
               
                 
              
               
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString11 %>" SelectCommand="SELECT * FROM [Alumniregistration]"></asp:SqlDataSource>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
               <%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                </div>
			</form>
		
	</body>
</html>
