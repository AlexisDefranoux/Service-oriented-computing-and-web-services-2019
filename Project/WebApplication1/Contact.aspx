<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" runat="server">
        <h3>Google map</h3>
        <hr class="my-1">

        <div id="map"></div>

        <script>
            function initMap() {
                var directionsService = new google.maps.DirectionsService();
                var directionsDisplay = new google.maps.DirectionsRenderer;
                var map = new google.maps.Map(document.getElementById('map'), {
                    zoom: 6,
                    center: { lat: 41.85, lng: -87.65 }
                });
                directionsDisplay.setMap(map);

                requestGoogleMaps(directionsService, directionsDisplay);
            }

            function requestGoogleMaps(directionsService, directionsDisplay) {
                console.log("LOL");
                directionsService.route(

                    {
                        origin:"<%=this.originAddress%>",
                        destination:"<%=this.destinationAddress%>",
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
