<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
  <form runat="server">
<head>
    <meta charset="UTF-8" />
    <title>Google Maps</title>
    <style type="text/css">
        #map-canvas {
            width: 700px;
            height: 500px;
            margin: 0 auto;
        }
    </style>
  
   <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCDALpLcb7b5J5YYhUy6ze6lu-7-9xAj7s&sensor=false"></script>
  <script type="text/javascript">
      function initialize() {
          var lat = parseFloat(document.getElementById("<%=HiddenField1.ClientID %>").value);
var lng = parseFloat(document.getElementById("<%=HiddenField2.ClientID %>").value);
var myLatlng = new google.maps.LatLng(lat, lng);
            
            var mapOptions = {
                zoom: 15,
                center: myLatlng,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            var map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);
            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
            });
 
            infowindow.open(map, marker);
            google.maps.event.addListener(marker, 'mouseover', function () {
                infowindow.open(map, marker);
            });
        }
    </script>
      
</head>
        </form>
<body onload="initialize()">
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:HiddenField ID="HiddenField2" runat="server" />
    <div id="map-canvas"></div>
</body>