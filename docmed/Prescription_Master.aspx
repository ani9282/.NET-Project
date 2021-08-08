<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prescription_Master.aspx.cs" Inherits="Prescription_Master" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">



    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
       <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
   
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
            padding: 0px 1px;
            height: 700px;
            width: 1037px;
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
           
 
#login .container #login-row #login-column #login-box {
  margin-top:0px;
  max-width: 750px;
  height: 890px;
  border: 1px solid #9C9C9C;
  background-color: #EAEAEA;
}
#login .container #login-row #login-column #login-box #login-form {
  padding: 20px;
}
#login .container #login-row #login-column #login-box #login-form #register-link {
  margin-top: -85px;
}
.state{
    width:100%;
            height: 32px;
        }

    </style>
   
</head>
<body>
 <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
      <a href="PatientDashboard.aspx">Home</a>
        <button class="dropdown-btn" style="width:200px;">
            Master
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">

            <a href="Prescription_Master.aspx">Prescription Master</a>
            <a href="patient_history.aspx">Patient History </a>
             </div>
        <a href="index.html">Logout</a>
    </div>
       
    <div class="content" style="background-image: url('img/department/5.png'); background-size:950px,1000px ;background-repeat: no-repeat">
         <div id="login">
        <h3 class="text-center text-white pt-5" ></h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12">
                        <form id="reg" class="form" runat="server" >
                             <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css"
        rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=TextBox1]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/Prescription_Master.aspx/GetCustomers") %>',
                        data: "{ 'prefix': '" + request.term + "'}",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    label: item.split('-')[0],
                                    val: item.split('-')[1]
                                }
                            }))
                        },
                        error: function (response) {
                            alert(response.responseText);
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        }
                    });
                },
                select: function (e, i) {
                    $("[id$=hfCustomerId]").val(i.item.val);
                },
                minLength: 1
            });
        });   
    </script>
                            <h3 class="text-center text-info">&nbsp;</h3>
                               <div class="form-group">
                                <label for="password" class="text-info">Ref ID:</label><br>
                                <input type="text" name="id" id="id" class="form-control" runat="server" required/>
                            </div>
                            <asp:Button ID="Button1" runat="server" Text="Show Data" OnClick="Button1_Click" />
                             <div class="form-group">
                                <label for="password" class="text-info">Patient Name:</label><br>
                                <input id="name" name="name" type="text" placeholder="name" class="form-control" value="<% =Address%>" /> 
                            </div>
                            <div class="form-group">
                                <label for="username" class="text-info"> Description:</label><br>
                                <%--<input type="text" name="username" id="username" class="form-control" value="" runat="server" required/>--%>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                                <div class="form-group">
                                <label for="username" class="text-info"> Quantity:</label><br>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                              <div class="form-group">
                                <label for="username" class="text-info"> Morning:</label><br>
                                  <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                                      <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Breakfast</asp:ListItem>
                                      <asp:ListItem>After Breakfast</asp:ListItem>
                                  </asp:DropDownList>
                                   <label for="username" class="text-info"> AfterNoon:</label><br>
                                  <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                                       <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Lunch</asp:ListItem>
                                      <asp:ListItem>After Lunch</asp:ListItem>
                                  </asp:DropDownList>
                                   <label for="username" class="text-info"> Night:</label><br>
                                  <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                                       <asp:ListItem>-</asp:ListItem>
                                      <asp:ListItem>Before Dinner</asp:ListItem>
                                      <asp:ListItem>After Dinner</asp:ListItem>
                                  </asp:DropDownList>

                            </div>
                            <div>
                                <asp:Button ID="Button" Text="Add" CssClass="btn btn-info btn-md"  runat="server" OnClick="Button_Click"/>
                            </div>
                      
                            <div class="form-group">
                                <asp:GridView ID="GridView1" runat="server">
                                </asp:GridView>
                                <br>
                                <asp:Button ID="Button2" runat="server" Text="Save" CssClass="btn btn-info btn-md" OnClick="Button2_Click"/>
                            
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <div id="register-link" class="text-right">
                                </div>
                            
                            </div>
                           <%-- <div id="register-link" class="text-right">
                                <a href="Register.aspx" class="text-info">Register here</a>
                            </div>--%>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

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
</body>
</html>
