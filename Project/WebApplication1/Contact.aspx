<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<style>
  #map {
        height: 400px;
        float: left;
        width: 400px;
      }
</style>

        <div id="map"></div>

        <!--<div id="right-panel">
        <div style="display: none">
            <input id="origin-input" class="controls" type="text"
                placeholder="Enter an origin location">

            <input id="origin-velib" class="controls" type="text"
                placeholder="Enter a velib here">
            <input id="destination-velib" class="controls" type="text"
                placeholder="Enter a velib here">
            <input id="destination-input" class="controls" type="text"
                placeholder="Enter a destination location">

            <div id="mode-selector" class="controls">
                <input type="radio" name="type" id="changemode-walking" checked="checked">
                <label for="changemode-walking">Walking</label>

                <input type="radio" name="type" id="changemode-transit">
                <label for="changemode-transit">Transit</label>

                <input type="radio" name="type" id="changemode-driving">
                <label for="changemode-driving">Driving</label>
            </div>
        </div>
    </div>-->
        <script>
 
  
            function initMap() {
           var  directionsService    = new google.maps.DirectionsService();
           var directionsDisplay = new google.maps.DirectionsRenderer;
           var  map = new google.maps.Map(document.getElementById('map'), {
                    zoom: 6,
                    center: { lat: 41.85, lng: -87.65 }
                });
                directionsDisplay.setMap(map);
                /* directionsDisplay.setMap(map);*/
                
                    requestGoogleMaps(directionsService, directionsDisplay);
            }

            function requestGoogleMaps(directionsService, directionsDisplay) {
                console.log("LOL");
                var waypts = [];
                waypts.push({
                    location: "<%=this.originNearestStationAddress%>",
                    stopover: true
                });
                waypts.push({
                    location: "<%=this.destinationNearestStationAddress%>",
                    stopover: true
                });
                directionsService.route(
                
                    {
                        origin:"<%=this.originAddress%>",
                        destination:"<%=this.destinationAddress%>",
                        waypoints: waypts,
                        optimizeWaypoints: true,
                       travelMode: "WALKING"
                    },
                    function (response, status) {
                        if (status === 'OK') {
                            directionsDisplay.setDirections(response);
                        } else {
                            window.alert('Directions request failed due to ' + status);
                        }
                    });
            }
        </script>
        <script async defer
            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAG6cBbOp7_ko1vu350eqXRrJR47MGIo7w&libraries=places&callback=initMap">
        </script>
  

    </div>
    </asp:Content>