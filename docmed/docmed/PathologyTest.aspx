<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PathologyTest.aspx.cs" Inherits="PathologyTest" %>

<!DOCTYPE html>

<html lang="en">
<head>
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">



    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
       <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title></title>
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
           .auto-style2 {
               font-style: italic;
               font-size: x-large;
           }
           .auto-style3 {
               width: 554px;
           }
           .auto-style4 {
               width: 725px;
           }
           .auto-style5 {
               height: 64px;
           }
           #date {
               width: 262px;
               height: 29px;
               margin-left: 0px;
           }
    </style>
      <style>
#customers {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 50%;
  table-layout: auto;
  margin-left: 400px;
}

#customers td, #customers th {
  border: 1px solid #ddd;
  padding: 2px;
}

#customers tr:nth-child(even){background-color: #f2f2f2;}

#customers tr:hover {background-color: #ddd;}

#customers th {
  padding-top: 30px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;

  color: white;
}

</style>
      <style>
        .width{
             column-width: 50px;
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
  margin-top: 40px;
  max-width: 700px;
  height: auto;
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
    <style>
        .center {
  text-align: center;

}
    </style>
</head>
<body>
  
               
               
    <div class="sidebar">
        <a class="active" href="#home">Dashbord</a>
       <a href="PathalogyDashboard.aspx">Home</a>

        <button class="dropdown-btn" style="width:200px;">
            Master 
            <i class="fa fa-caret-down"></i>
        </button>
      <div class="dropdown-container">
           
        
            <a href="RecommandedTest.aspx">Recommanded Test</a>
            <a href="PathologyTest.aspx"> Test</a>
            <a href="Laboratorydata.aspx">Document</a>
          

            
        </div>
        <a href="Logout.aspx">Logout</a>
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
    <br /><br /> <br />

    <form runat="server">
    <table border="4" align="center" cellpadding="3" cellspacing="2" style="height: 50px; width: 35%;">
     <tr>
        <th align="center"  bgcolor="Cyan" style="color: black" colspan="4" class="auto-style5"><h1 class="auto-style2" align="center">Patient Information</h1></th>
     </tr>
              <tr>
     <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Ref ID:</label>
                              
            </th>
     <td class="auto-style4">
          
            <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="200px"></asp:TextBox >&nbsp;&nbsp;
             <asp:Button ID="Button1" runat="server" Text="Show Data" OnClick="Button1_Click" />
       
        
     </td>
           
       
     
     <th align="center" class="auto-style3">
            <label for="password" class="text-info">Name</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="320px"   ReadOnly="true"  CssClass="form-control"></asp:TextBox>
     </td>
    </tr>

   

     <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">DOB:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox5" runat="server" Height="29px" Width="320px" ReadOnly="true"  CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">&nbsp;&nbsp;
             <label for="password" class="text-info">Mobile</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox6" runat="server" Height="29px" Width="320px" ReadOnly="true"  CssClass="form-control"></asp:TextBox>
     </td>
     </tr>


    <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Address:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox7" runat="server" Height="29px" Width="320px" ReadOnly="true"  CssClass="form-control"></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">
            <label for="password" class="text-info">Blood Group</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox8" runat="server" Height="29px" Width="320px" ReadOnly="true"  CssClass="form-control"></asp:TextBox>
     </td>
     </tr>



         <tr>
     <th align="center" class="auto-style3">
             <label for="password" class="text-info">Gender:</label>
            </th>
     <td class="auto-style4">
        <asp:TextBox ID="TextBox9" runat="server" Height="29px" Width="320px" ReadOnly="true" CssClass="form-control" ></asp:TextBox>
     </td>
    <th align="center" class="auto-style3">
            <label for="password" class="text-info">Insurance</label>
            </th>
     <td class="auto-style4">
         <asp:TextBox ID="TextBox10" runat="server" Height="29px" Width="320px" ReadOnly="true" CssClass="form-control"></asp:TextBox>
     </td>
     </tr>
        
        </table>
       
    <br /> <br /> 


    <table id="customers">

        <tr>
             <th style="text-align:center" colspan="6">CBC TEST</th>
        </tr>
       
  <tr>
    <th style="text-align:center" width="50px" >Check Box</th>
    <th style="text-align:center" width="200px">Test Parameter</th>
    <th style="text-align:center" width="10px">Required</th>
    <th style="text-align:center" width="10px">results</th>
     <th style="text-align:center" width="100px">Discription</th>
  </tr>

  <tr>
    <td align="left"> <input id="Checkbox1" type="checkbox" name="ch1" width:"40px" height:"40px" > </td>
    <td font size="15">White Blood Cell (WBC)</td>
    <td align="center"><input type="text" name="required1" value="3.8-1000" size="10" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results1" size="5" style="font-size:10pt;"></td>
    <td align="center"><input type="text" name="discription1"  size="42" style="font-size:10pt;"></td>
  </tr>

        
   <tr>
    <td align="left"> <input id="Checkbox2" type="checkbox" name="ch2"  width:"40px" height:"40px" > </td>
    <td>Red Blood Cell (WBC)</td>
    <td align="center"><input type="text" name="required2" size="10" value="4.2–5600000" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results2" size="5" style="font-size:10pt;"></td>
    <td align="center"><input type="text" name="discription2" size="42" style="font-size:10pt;"></td>
  </tr>

         <tr>
    <td align="left"> <input id="Checkbox3" type="checkbox" name="ch3"   width:"40px" height:"40px" > </td>
    <td>Hemoglobin (Hgb)</td>
   <td align="center"><input type="text" name="required3" size="10" value="11-18"  style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results3" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription3" size="42" style="font-size:10pt;"></td>
  </tr>

        
    <tr>
    <td align="left"> <input id="Checkbox4" type="checkbox" name="ch4" width:"40px" height:"40px" > </td>
    <td>Hematocrit (Hct)</td>
   <td align="center"><input type="text"  name="required4" size="10" value="39-54" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results4" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription4" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <input id="Checkbox5" type="checkbox" name="ch5"  width:"40px" height:"40px" > </td>
    <td>Mean corpuscular volume (MCV)</td>
    <td align="center"><input type="text" name="required5" size="10" value="80-100" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results5" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription5" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <input id="Checkbox6" type="checkbox" name="ch6"  width:"40px" height:"40px" > </td>
    <td>Platelet count (Plts)</td>
   <td align="center"><input type="text" name="required6" size="10" value="140000–450000" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results6" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription6" size="42" style="font-size:10pt;"></td>
  </tr>
        -->
</table>
   <br /> <br />


    <table id="customers">

        <tr>
             <th style="text-align:center" colspan="6">Basic Metabolic/Electrolyte Panel</th>
        </tr>
       
  <tr>
    <th style="text-align:center" width="50px">Check Box</th>
    <th style="text-align:center" width="200px">Test Parameter</th>
    <th style="text-align:center" width="10px">Required</th>
    <th style="text-align:center" width="10px">results</th>
  
     <th style="text-align:center" style="500px">Discription</th>
  </tr>

  <tr>
    <td align="left"> <input id="Checkbox7" type="checkbox" name="ch7"  width:"40px" height:"40px" > </td>
    <td font size="15">Sodium </td>
    <td align="center"><input type="text" name="required7" size="10" value="30-280" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results7" size="5" style="font-size:10pt;"></td>
  
    <td align="center"><input type="text" name="discription7" size="42" style="font-size:10pt;"></td>
  </tr>

   <tr>
    <td align="left"> <input id="Checkbox8" type="checkbox" name="ch8" width:"40px" height:"40px" > </td>
    <td>Potassium</td>
    <td align="center"><input type="text" name="required8" size="10" value="35-85" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results8" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription8" size="42" style="font-size:10pt;"></td>
  </tr>

         <tr>
    <td align="left"> <input id="Checkbox9" type="checkbox" name="ch9"  width:"40px" height:"40px" > </td>
    <td>Chloride</td>
   <td align="center"><input type="text" name="required9" size="10" value="110-250" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results9" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription9" size="42" style="font-size:10pt;"></td>
  </tr>

    <tr>
    <td align="left"> <input id="Checkbox10" type="checkbox" name="ch10"  width:"40px" height:"40px" > </td>
    <td>Carbon dioxide (CO2)</td>
   <td align="center"><input type="text" name="required10" size="10" value="23-29" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results10" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription10" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <input id="Checkbox11" type="checkbox" name="ch11"  width:"40px" height:"40px" > </td>
    <td>Blood urea nitrogen (BUN)</td>
    <td align="center"><input type="text" name="required11" size="10" value="10-22" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results11" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription11" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <input id="Checkbox12" type="checkbox" name="ch12"  width:"40px" height:"40px" > </td>
    <td>Creatinine</td>
   <td align="center"><input type="text" name="required12" size="10" value="1-2" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results12" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription12" size="42" style="font-size:10pt;"></td>
  </tr>

 <tr>
    <td align="left"> <input id="Checkbox13" type="checkbox" name="ch13"  width:"40px" height:"40px" > </td>
    <td>Glucose</td>
   <td align="center"><input type="text" name="required13" size="10" value="40-85" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results13" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription13" size="42" style="font-size:10pt;"></td>
  </tr>
</table>
   <br /> <br />


    <table id="customers">

        <tr>
             <th style="text-align:center" colspan="6">Comprehensive Metabolic Panel</th>
        </tr>
       
  <tr>
    <th style="text-align:center" width="50px">Check Box</th>
    <th style="text-align:center" width="200px">Test Parameter</th>
    <th style="text-align:center" width="10px">Required</th>
    <th style="text-align:center" width="10px">results</th>
   
     <th style="text-align:center" style="500px">Discription</th>
  </tr>

  <tr>
    <td align="left"> <input id="Checkbox14" type="checkbox" name="ch14"  width:"40px" height:"40px" > </td>
    <td font size="15">Calcium</td>
    <td align="center"><input type="text" name="required14" size="10" value="8-11" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results14" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription14" size="42" style="font-size:10pt;"></td>
  </tr>

   <tr>
    <td align="left"> <input id="Checkbox15" type="checkbox" name="ch15"  width:"40px" height:"40px" > </td>
    <td>Total protein</td>
    <td align="center"><input type="text" name="required15" size="10" value="5-9" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results15" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription15" size="42" style="font-size:10pt;"></td>
  </tr>

         <tr>
    <td align="left"> <input id="Checkbox16" type="checkbox" name="ch16"  width:"40px" height:"40px" > </td>
    <td>Albumin</td>
   <td align="center"><input type="text" name="required16" size="10" value="3.5-5.0" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results16" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription16" size="42" style="font-size:10pt;"></td>
  </tr>

    <tr>
    <td align="left"> <input id="Checkbox17" type="checkbox" name="ch17"  width:"40px" height:"40px" > </td>
    <td>Bilirubin (total)</td>
   <td align="center"><input type="text" name="required17" size="10" value="0.2-1.4" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results17" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription17" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <inputid="Checkbox18" type="checkbox" name="ch18"  width:"40px" height:"40px" > </td>
    <td>Alkaline phosphatase</td>
    <td align="center"><input type="text" name="required18" size="10" value="32-110" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results18" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription18" size="42" style="font-size:10pt;"></td>
  </tr>


   <tr>
    <td align="left"> <input id="Checkbox19" type="checkbox" name="ch19"  width:"40px" height:"40px" > </td>
    <td>AST (aspartate aminotransferase)</td>
   <td align="center"><input type="text" name="required19" size="10" value="7-21" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results19" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription19" size="42" style="font-size:10pt;"></td>
  </tr>

  <tr>
    <td align="left"> <input id="Checkbox20" type="checkbox" name="ch20"  width:"40px" height:"40px" > </td>
    <td>ALT (alanine aminotransferase)</td>
   <td align="center"><input type="text" name="required20" size="10" value="29-33" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results20" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription20" size="42" style="font-size:10pt;"></td>
  </tr>
</table>
   <br /> <br />

<table id="customers">

        <tr>
             <th style="text-align:center" colspan="6">Lipid (cholesterol) panel</th>
        </tr>
       
  <tr>
    <th style="text-align:center" width="50px">Check Box</th>
    <th style="text-align:center" width="200px">Test Parameter</th>
    <th style="text-align:center" width="10px">Required</th>
    <th style="text-align:center" width="10px">results</th>
   
     <th style="text-align:center" style="500px">Discription</th>
  </tr>

  <tr>
    <td align="left"> <input id="Checkbox21" type="checkbox" name="ch21"  width:"40px" height:"40px" > </td>
    <td font size="15">Total cholesterol</td>
    <td align="center"><input type="text" name="required21" size="10" value="Less than 200" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results21" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription21" size="42" style="font-size:10pt;"></td>
  </tr>

   <tr>
    <td align="left"> <input id="Checkbox22" type="checkbox" name="ch22"  width:"40px" height:"40px" > </td>
    <td>High-density lipoprotein (HDL)  cholesterol</td>
    <td align="center"><input type="text" name="required22" size="10" value="30-75" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results22" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription22" size="42" style="font-size:10pt;"></td>
  </tr>

         <tr>
    <td align="left"> <input id="Checkbox23" type="checkbox" name="ch23"  width:"40px" height:"40px" > </td>
    <td>ow-density lipoprotein (LDL) cholesterol</td>
   <td align="center"><input type="text" name="required23" size="10" value="Less than 130" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results23" size="5" style="font-size:10pt;"></td>
    
    <td align="center"><input type="text" name="discription23" size="42" style="font-size:10pt;"></td>
  </tr>

    <tr>
    <td align="left"> <input id="Checkbox24" type="checkbox" name="ch24"  width:"40px" height:"40px" > </td>
    <td>Triglycerides</td>
   <td style="center"><input type="text" name="required24" size="10" value="170" style="font-size:10pt;" readonly></td>
    <td align="center"><input type="text" name="results24" size="5" style="font-size:10pt;"></td>
   
    <td align="center"><input type="text" name="discription24" size="42" style="font-size:10pt;"></td>
  </tr>

   
</table>
        -->
   <br /> 
        <div class="center">
            <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" />
        </div>
        <br />
        </form>
</body>
</html>
