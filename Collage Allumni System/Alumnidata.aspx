<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumnidata.aspx.cs" Inherits="Alumnidata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alumni Data</title>
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
    <style>
        .margin {
  margin-left: 330px;
 
}
    </style>
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
             <a href="Alumnidata.aspx">Alumni Data</a>
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
           
			<div class="margin">
                 
                
			<h2>Alumni Data</h2>
                <p> Alumni Name</p>
		 <asp:TextBox ID="textinput" runat="server"></asp:TextBox>  
                <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />  
                   <table><tr><td><p><asp:Label ID="Label2" runat="server"></asp:Label>  </p></td></tr>  
  
</table>  

                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString7 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString2 %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%><%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:collage AlumniConnectionString %>" SelectCommand="SELECT * FROM [staffregistration]"></asp:SqlDataSource>--%>
                
              <asp:GridView ID="GridView1" runat="server" ></asp:GridView>  
        <p>  
             </p>  
                      </div>
               
         
            
			</form>
		
	</body>
</html>
