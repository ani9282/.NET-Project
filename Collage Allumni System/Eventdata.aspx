<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eventdata.aspx.cs" Inherits="Eventdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
	width: 550px;
	height: 500px;
	padding: 50px 50px;
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
	padding: 0 0 30px;
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
    .auto-style13 {
        margin-left: 0px;
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
		<title>Alumni | Event Master</title>

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
            <a href="Eventmaster1.aspx">Event Master</a>
             <a href="Eventdata.aspx">Event Data</a>
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
        <form id="form1" runat="server">
			<div class="loginBox">
                <%--<img src="image/newlogin.png" class="user" alt="ECS">--%>
			<h2>Event Data</h2>
                
				<p>Event Name</p>
                <p>&nbsp;</p>
                <p>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Teachers Day</asp:ListItem>
                        <asp:ListItem>Freshers Party</asp:ListItem>
                        <asp:ListItem>Gathering</asp:ListItem>
                        <asp:ListItem>Send off</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p>&nbsp;</p>
               
                
              
            
                <asp:RadioButton ID="RadioButton1" runat="server" Text="instreted" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Not Intrested" /> <br />
                
				
                <%--<asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" />	--%>&nbsp;
                <%--  <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Event"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbtn1" runat="server" ForeColor="White" OnCheckedChanged="RadioButton1_CheckedChanged2" Text="Intrested" />
                <asp:RadioButton ID="rbtn2" runat="server" ForeColor="White" Text="Not Intrested" />
                <br />
                <br />--%>
                
                 
             
                
                 
                <asp:Button ID="Update" runat="server" Text="Show Count" OnClick="Button3_Click" Width="120px" />	<br />
                
                   <asp:Label ID="Label1" runat="server" Text="Label" ></asp:Label>

                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString14 %>" SelectCommand="SELECT * FROM [Eventmaster1]"></asp:SqlDataSource>
                </div>
			</form>
		
	</body>
</html>
