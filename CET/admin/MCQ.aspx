<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MCQ.aspx.cs" Inherits="admin_MCQ" %>

<html>
<head>
<title>CET</title>
</head>
<body bgcolor=#ffffff>

<h3>Vocabulary Quiz I</h3>

<form method="post" action="mailto:raizen@mail.utexas.edu?subject=Vocabulary Quiz 1" enctype="text/plain" runat="server">


<P>
<label for="qno">Q. No&nbsp&nbsp&nbsp&nbsp:&nbsp&nbsp&nbsp</label>
 <asp:TextBox ID="tb_Subject"  Height="40px" Width="600px" Enabled="false" runat="server"></asp:TextBox>   
     <br />
    <br />
<label for="qno">Q. Name&nbsp:&nbsp&nbsp</label>
 <asp:TextBox ID="TextBox1"  Height="100px" Width="600px" Enabled="false" runat="server"></asp:TextBox>    <br />
    <br />
    <br />

<label for="qno">Option A&nbsp:&nbsp&nbsp</label>
 <asp:TextBox ID="TextBox2"  Height="100px" Width="600px" Enabled="false" runat="server"></asp:TextBox>    <br />
    <br />
    <br />

<label for="qno">Option B&nbsp:&nbsp&nbsp</label>
 <asp:TextBox ID="TextBox3"  Height="100px" Width="600px" Enabled="false" runat="server"></asp:TextBox>    <br />
    <br />
    <br />

<label for="qno">Option C&nbsp:&nbsp&nbsp</label>
 <asp:TextBox ID="TextBox4"  Height="100px" Width="600px" Enabled="false" runat="server"></asp:TextBox>    <br />
    <br />
    <br />

<label for="qno">Option D&nbsp:&nbsp&nbsp</label>
 <asp:TextBox ID="TextBox5"  Height="100px" Width="600px" Enabled="false" runat="server"></asp:TextBox>    <br />
    <br />
    <br />

</p>

<input type="submit" value="prev">
<input type="submit" value="submit">
<input type="reset" value="next">
</form>
</body>
</html>