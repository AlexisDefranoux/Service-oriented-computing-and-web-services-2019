<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Ton trajet en Velib</h2>
        <hr class="my-1">
        <p class="lead">Génére ton trajet en fonction de ta position, ta destination et le vélib le plus prochaine !</p>
    </div>

    <div class="jumbotron">
        <h3>Saisissez l'addresse de départ et l'adresse d'arrivée</h3>
        <hr class="my-1">

        <div class="form-group">
            <label for="ville">Ville</label>
            <asp:DropDownList ID="ville" runat="server" CssClass="form-control col-6"></asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="inputStart">Adresse de départ</label>
            <input type="text" runat="server" class="form-control" id="inputStart" placeholder="1234 Main St">
        </div>

        <div class="form-group">
            <label for="inputEnd">Adresse d'arrivé</label>
            <input type="text" runat="server" class="form-control" id="inputEnd" placeholder="1234 Main St">
        </div>
        <asp:Button ID="Button1" runat="server" Text="Valider" class="btn btn-primary" OnClick="Button1_Click" />
    </div>

    <div class="jumbotron" runat="server">
        <h3>Google map</h3>
        <hr class="my-1">

        <select id="cbStation" runat="server">
            <option></option>
        </select>

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
                var directionsService = new google.maps.DirectionsService;
                var directionsDisplay = new google.maps.DirectionsRenderer;
                var map = new google.maps.Map(document.getElementById('map'), {
                    mapTypeControl: false,
                    zoom: 6,
                    center: { lat: 41.85, lng: -87.65 }
                });
                new AutocompleteDirectionsHandler(map);
                /* directionsDisplay.setMap(map);*/
            }

            /**
             * @constructor
             */
            function AutocompleteDirectionsHandler(map) {
                this.map = map;
                this.originPlaceId = null;
                this.destinationPlaceId = null;
                this.originVelibId = null;
                this.destinationVelibId = null;
                this.travelMode = 'WALKING';
                this.directionsService = new google.maps.DirectionsService;
                this.directionsDisplay = new google.maps.DirectionsRenderer;
                this.directionsDisplay.setMap(map);

                var originInput = document.getElementById('origin-input');
                var destinationInput = document.getElementById('destination-input');
                var originVelib = document.getElementById('origin-velib');
                var destinationVelib = document.getElementById('destination-velib');
                var modeSelector = document.getElementById('mode-selector');

                var originAutocomplete = new google.maps.places.Autocomplete(originInput);
                // Specify just the place data fields that you need.
                var originVelibsAutoComplete = new google.maps.places.Autocomplete(originVelib);
                originVelibsAutoComplete.setFields(['place_id', 'name']);
                originAutocomplete.setFields(['place_id', 'name']);

                var destinationAutocomplete =
                    new google.maps.places.Autocomplete(destinationInput);

                // Specify just the place data fields that you need.
                destinationAutocomplete.setFields(['place_id', 'name']);

                var destinationVelibsAutoComplete = new google.maps.places.Autocomplete(destinationVelib);
                destinationVelibsAutoComplete.setFields(['place_id', 'name']);
                this.setupClickListener('changemode-walking', 'WALKING');
                this.setupClickListener('changemode-transit', 'TRANSIT');
                this.setupClickListener('changemode-driving', 'DRIVING');

                this.setupPlaceChangedListener(originAutocomplete, 'ORIG');
                this.setupPlaceChangedListener(destinationAutocomplete, 'DEST');
                this.setupPlaceChangedListener(originVelibsAutoComplete, 'ORIGIN_VELIB');
                this.setupPlaceChangedListener(destinationVelibsAutoComplete, 'DESTINATION_VELIB');

                this.map.controls[google.maps.ControlPosition.TOP_LEFT].push(originInput);
                this.map.controls[google.maps.ControlPosition.TOP_LEFT].push(
                    destinationInput);
                this.map.controls[google.maps.ControlPosition.TOP_LEFT].push(modeSelector);
                this.map.controls[google.maps.ControlPosition.TOP_LEFT].push(originVelib);
                this.map.controls[google.maps.ControlPosition.TOP_LEFT].push(destinationVelib);
            }

            // Sets a listener on a radio button to change the filter type on Places
            // Autocomplete.
            AutocompleteDirectionsHandler.prototype.setupClickListener = function (
                id, mode) {
                var radioButton = document.getElementById(id);
                var me = this;

                radioButton.addEventListener('click', function () {
                    me.travelMode = mode;
                    me.route();
                });
            };

            AutocompleteDirectionsHandler.prototype.setupPlaceChangedListener = function (
                autocomplete, mode) {
                var me = this;

                autocomplete.addListener('place_changed', function () {
                    var place = autocomplete.getPlace();

                    if (!place.place_id) {
                        window.alert('Please select an option from the dropdown list.');
                        return;
                    }
                    if (mode === 'ORIG') {
                        me.originPlaceId = place.name;
                    } else if (mode === 'DEST') {
                        me.destinationPlaceId = place.name;
                    }
                    else if (mode === 'ORIGIN_VELIB') {
                        me.originVelibId = place.name;
                    }
                    else {
                        me.destinationVelibId = place.name;
                    }
                    me.route();
                });
            };

            AutocompleteDirectionsHandler.prototype.route = function () {
                if (!this.originPlaceId || !this.destinationPlaceId || !this.originVelibId || !this.destinationVelibId) {
                    return;
                }
                var me = this;
                var waypts = [];
                waypts.push({
                    location: this.originVelibId,
                    stopover: true
                });
                waypts.push({
                    location: this.destinationVelibId,
                    stopover: true
                });

                this.directionsService.route(
                    {
                        origin: this.originPlaceId,
                        destination: this.destinationPlaceId,
                        waypoints: waypts,
                        optimizeWaypoints: true,
                        travelMode: this.travelMode
                    },
                    function (response, status) {
                        if (status === 'OK') {
                            me.directionsDisplay.setDirections(response);
                        } else {
                            window.alert('Directions request failed due to ' + status);
                        }
                    });
            };
        </script>
        <script async defer
            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAG6cBbOp7_ko1vu350eqXRrJR47MGIo7w&libraries=places&callback=initMap">
        </script>
    </div>

</asp:Content>
