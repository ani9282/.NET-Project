<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staffreg.aspx.cs" Inherits="Staffreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
        .auto-style2 {
            height: 42px;
            width: 142px;
        }
        .auto-style3 {
            height: 42px;
            width: 186px;
        }
        .auto-style4 {
            height: 42px;
            width: 193px;
        }
    </style>
</head>
<body>
   <%-- <form id="form1" runat="server">
    <div>



    
    </div>
    </form>--%>




    <form id="form1" runat="server">
    
       <table border="2" align="center" width="50%" cellpadding="5" cellspacing="6" style="height: 336px">
     <tr>
        <th align="center" bgcolor="indigo" style="color: white" colspan="6"><h1><em>Staff Registration</em></h1></th>
     </tr>
     <tr>
     <th align="center" class="auto-style2"> Id</th>
     <td class="auto-style1">
         <asp:TextBox ID="txtteacherid" runat="server" Width="200px"></asp:TextBox>
     </td>
     </tr>
     <tr>
     <th align="center" class="auto-style2">Teacher Name</th>
     <td class="auto-style1">
         
          <asp:TextBox ID="txtteachername" runat="server" Style="width:99%"></asp:TextBox>
         <td>
<%--             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BackColor="#FF3300" ControlToValidate="txtteachername" ErrorMessage="*"></asp:RegularExpressionValidator>--%>
         </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Mobile No</th>
     <td class="auto-style1">
         
          <asp:TextBox ID="txtmobno" runat="server" Style="width:99%"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" BackColor="#FF3300" ControlToValidate="txtmobno" ErrorMessage="mobile number must be ten digit" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Email Id</th>
     <td class="auto-style1">
         
          <asp:TextBox ID="TextBox1" runat="server" Width="182px"></asp:TextBox>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" BackColor="#FF3300" ControlToValidate="txtemailid" ErrorMessage="email address must be valid"></asp:RegularExpressionValidator>
               </td>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">Branch Name</th>
     <td class="auto-style1">
         
          <asp:TextBox ID="TextBox2" runat="server" Width="179px"></asp:TextBox>
     </td>
     </tr>
           <tr>
     <th align="center" class="auto-style2">photo</th>
     <td class="auto-style1">
         
          <asp:FileUpload ID="FileUpload1" runat="server" />
     </td>
    
                    
     </tr>
           
         <td class="auto-style3">
                <asp:Button ID="btnnew" runat="server" Text="New" 
                    Width="110px" Font-Bold="True" Height="31px" align="center" OnClick="btnnew_Click" CausesValidation="False" BackColor="#FFCCFF" style="font-style: italic"/>
             <td class="auto-style4">
                <asp:Button ID="btnsave" runat="server" Text="Save" 
                    Width="115px" Font-Bold="True" Height="31px" align="center" OnClick="btnsave_Click" BackColor="#FFCCFF" style="font-style: italic"/>
         <td style="width: 131px; height: 42px;">
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                    Width="89px" Font-Bold="True" Height="31px" align="center" OnClick="btnupdaqte_Click" BackColor="#FFCCFF" style="font-style: italic"/>
         
            
            <td style="width: 203px; height: 42px;">
                <asp:Button ID="btndelete" runat="server" Text="Delete" 
                    Width="84px" Font-Bold="True" Height="31px" align="center" OnClick="btndelete_Click" BackColor="#FFCCFF" style="font-style: italic"  />
            </td>
   


           
     
    </table>
     <br />
            <asp:Panel ID="Panel1" runat="server" Height="274px" BorderStyle="Solid" style="margin-left: 290px" Width="838px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="493px"  >
                    <Columns>
                        <asp:BoundField DataField="teacherid" HeaderText="teacherid" SortExpression="teacherid" />
                        <asp:BoundField DataField="teachername" HeaderText="teachername" SortExpression="teachername" />
                        <asp:BoundField DataField="mobileno" HeaderText="mobileno" SortExpression="mobileno" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="branchname" HeaderText="branchname" SortExpression="branchname" />
                        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString5 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>
             </asp:Panel>
            <br />
            <br />
        </form> </div>
    <hr />
    

<%--    <script src="~/Scripts/jquery-1.10.2.min.js"></script>
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
    </script>--%>
            
</body>
</html>
