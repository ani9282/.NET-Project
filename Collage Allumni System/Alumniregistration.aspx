﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumniregistration.aspx.cs" Inherits="Alumniregistration" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>



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
		<meta charset="utf-8">
		<title>Alumni  | Alumni Registration</title>

	</head>
	<body>

        <form id="form1" runat="server">
			<div class="loginBox">
			<%--<img src="image/newlogin.png" class="user" alt="ECS">--%>
			<h2>Alumni Registration</h2>
                <p> Alumni Id</p>
                <asp:TextBox ID="txtid"  type="text"   runat="server" Width="154px"></asp:TextBox>
				<p>Alumni Name</p>
                <asp:TextBox ID="txtname"  type="text"   runat="server"></asp:TextBox>
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
                <p class="auto-style4">&nbsp;</p>
                <p class="auto-style4">Mobile NO</p>
				<asp:TextBox ID="txtmobile"  type="text"  runat="server" CssClass="auto-style2"></asp:TextBox> <%--type="password" name="password" placeholder="Enter Password" required>--%>
                <p>Email</p>
				<asp:TextBox ID="txtemail"  type="text"  runat="server" CssClass="auto-style8"></asp:TextBox> <%--type="password" name="password" placeholder="Enter Password" required>--%>
              <p>&nbsp;Address</p>
                <asp:TextBox ID="txtadd"  type="text"   runat="server" CssClass="auto-style6"></asp:TextBox>
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                 <asp:FileUpload ID="FileUpload1" runat="server" Width="557px" CssClass="auto-style5" />
                 
                <%--<asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" />	--%>
                <asp:Button ID="save" runat="server" Text="save" OnClick="Button1_Click" />	
                 
                 <asp:Button ID="new" runat="server" Text="New" OnClick="Button2_Click" />	
                 
                 <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" CssClass="auto-style1" />		
                 
                <asp:Button ID="Update" runat="server" Text="Update" OnClick="Button3_Click" Width="73px" />	
                <asp:GridView ID="GridView1" runat="server" Width="16px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="92px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="alumniid" HeaderText="alumniid" SortExpression="alumniid" />
                        <asp:BoundField DataField="alumniname" HeaderText="alumniname" SortExpression="alumniname" />
                        <asp:BoundField DataField="mobileno" HeaderText="mobileno" SortExpression="mobileno" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="branchname" HeaderText="branchname" SortExpression="branchname" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString11 %>" SelectCommand="SELECT * FROM [Alumniregistration]"></asp:SqlDataSource>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
               <%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                </div>
			</form>
		
	</body>
</html>


