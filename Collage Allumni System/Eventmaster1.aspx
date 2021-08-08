<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eventmaster1.aspx.cs" Inherits="Eventmaster1" %>

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
	width: 500px;
	height: 590px;
	padding: 60px 50px;
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
	padding: 0 0 40px;
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
    .auto-style9 {
        margin-left: 0px;
        margin-top: 9px;
    }
    .auto-style12 {
        margin-top: 10px;
    }
    .auto-style13 {
        margin-left: 0px;
    }
    .auto-style14 {
        margin-bottom: 0px;
    }
    </style>
		<meta charset="utf-8">
		<title>Alumni | Event Master</title>

	</head>
	<body>
        <form id="form1" runat="server">
			<div class="loginBox">
                <%--<img src="image/newlogin.png" class="user" alt="ECS">--%>
			<h2>Event Master</h2>
                <p>&nbsp;Event Id</p>
                &nbsp;<asp:TextBox ID="txtid"  type="text"   runat="server" Width="154px" CssClass="auto-style9"></asp:TextBox>
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
                <p>&nbsp;Date</p>
                <p>
                    &nbsp;<asp:TextBox ID="textbox1"  type="date"   runat="server" CssClass="auto-style12" OnTextChanged="date_TextChanged"></asp:TextBox>
                </p>
                
               
                
				
                <%--<asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" />	--%>&nbsp;
                <%--  <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Event"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbtn1" runat="server" ForeColor="White" OnCheckedChanged="RadioButton1_CheckedChanged2" Text="Intrested" />
                <asp:RadioButton ID="rbtn2" runat="server" ForeColor="White" Text="Not Intrested" />
                <br />
                <br />--%>
                <asp:Button ID="save" runat="server" Text="save" OnClick="Button1_Click" CssClass="auto-style13" />	
                 
                 <asp:Button ID="new" runat="server" Text="New" OnClick="Button2_Click" />	
                 
                 <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Button4_Click" CssClass="auto-style1" />		
                 
                <asp:Button ID="Update" runat="server" Text="Update" OnClick="Button3_Click" Width="73px" />	
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" CssClass="auto-style14">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Eventid" HeaderText="Eventid" SortExpression="Eventid" />
                        <asp:BoundField DataField="Eventname" HeaderText="Eventname" SortExpression="Eventname" />
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString14 %>" SelectCommand="SELECT * FROM [Eventmaster1]"></asp:SqlDataSource>
                </div>
			</form>
		
	</body>
</html>


