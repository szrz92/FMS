var map;
var markers = [];
function initialize(dotNetObjectReference, data) {
    var latlng = new google.maps.LatLng(30.3753, 69.3451);
    var options = {
        zoom: 6,
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    map = new google.maps.Map(document.getElementById("map"), options);

    setMarkers(dotNetObjectReference, data);
}
function setMarkers(dotNetObjectReference, data) {
    //console.log(JSON.stringify(data));
    const legend = document.getElementById("legend");
    map.controls[google.maps.ControlPosition.LEFT_BOTTOM].clear();
    map.controls[google.maps.ControlPosition.LEFT_BOTTOM].push(legend);
    const iconBase = "assets/icons/";
    const icons = {
        maintained: {
            name: "Maintained",
            color: "#00CB14",
            icon: iconBase + "Maintained2x.png",
        },
        periodic: {
            name: "Periodic",
            color: "#FF6F00",
            icon: iconBase + "Periodic2x.png",
        },
        emergency: {
            name: "Emergency",
            color: "#DFBB0B",
            icon: iconBase + "Emergency2x.png",
        },
        accidental: {
            name: "Accidental",
            color: "#FF0000",
            icon: iconBase + "Accidental2x.png",
        },
    };

    const features = [];

    data.forEach((datum) => {
        //console.log(JSON.stringify(datum));
        const feature = {
            "position": new google.maps.LatLng(datum.latitude, datum.longitude),
            "type": datum.type,
            "number": datum.vehicleNumber,
            "driverName": datum.driverName
        };
        //console.log(JSON.stringify(feature));

        features.push(feature);
    });
    var infoWindows = [];
    features.forEach((feature) => {
        var marker = new google.maps.Marker({
            position: feature.position,
            label: {
                text: feature.number,
                color: "#FFFFFF",
                fontSize: "12px",
                fontWeight: "bold"
            },
            icon: { url: icons[feature.type].icon, scaledSize: new google.maps.Size(60, 40) },

            map: map,
        });
        const infowindow = new google.maps.InfoWindow({
            content: '<div id="content">'
                + '<div id="bodyContent">'
                + '<table class="table table-borderless">'
                + '<tr><td>Driver Name :</td><td>' + feature.driverName + '</td></tr>'
                + '<tr><td>Number of trips :</td><td>05</td></tr>'
                //+ '<tr><td>Fuel Consumed :</td><td>10 Ltr</td></tr>'
                + '<tr><td>KMs :</td><td>150 km</td></tr>'
                + '<table>'
                + '<p>Tyres replacement due in 500 KMs</p>'
                + ' <p>'
                + '<a class="btn text-white mr-2" style="background-color:#DFBB0B" href="javascript:emergencyDotNetFunc(\'' + feature.number.toString() + '\')"> EMERGENCY</a>'
                + '<a class="btn text-white mr-2" style="background-color:#FF0000" href="javascript:accidentalDotNetFunc(\'' + feature.number.toString() + '\')"> ACCIDENTAL</a>'
                + '<a class="btn text-white mr-2" style="background-color:#FF6F00" onclick="dailyDotNetFunc(\'' + feature.number.toString() + '\');"> DAILY</a>'
                + '</p>'
                + ' <h3 style="margin-left:30%;">'
                + '<a class="btn text-dark mr-2" style="border: 1px solid #adb5bd;width:70%;" href="javascript:historyDotNetFunc(\'' + feature.number.toString() + '\')">'
                + '<img style="margin-right: 5px; height:20px;" alt="Pic" src="assets/icons/History1x.png"/>History</a>'
                + '</h3>'
                + '</div>'
                + '</div>',
        });
        //add infowindow to array
        infoWindows.push(infowindow);

        marker.addListener('click', function () {
            for (var i = 0; i < infoWindows.length; i++) {
                infoWindows[i].close();
            }
            infowindow.open(map, marker);
            //setTimeout(function () { infowindow.close(); }, 5000);
        });
        markers.push(marker);
    });

    window.emergencyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber);
        dotNetObjectReference.invokeMethodAsync("Emergency_JSInvoked", vehicleNumber);
    };
    window.accidentalDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("Accidental_JSInvoked", vehicleNumber);
    };

    window.dailyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("Daily_JSInvoked", vehicleNumber);
    };
    window.historyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("History_JSInvoked", vehicleNumber);
    };
}
function updateMarkerPositions(dotNetObjectReference, data) {
    try {
        const legend = document.getElementById("legend");
        map.controls[google.maps.ControlPosition.LEFT_BOTTOM].clear();
        map.controls[google.maps.ControlPosition.LEFT_BOTTOM].push(legend);

        const iconBase = "assets/icons/";
        const icons = {
            maintained: {
                name: "Maintained",
                color: "#00CB14",
                icon: iconBase + "Maintained2x.png",
            },
            periodic: {
                name: "Periodic",
                color: "#FF6F00",
                icon: iconBase + "Periodic2x.png",
            },
            emergency: {
                name: "Emergency",
                color: "#DFBB0B",
                icon: iconBase + "Emergency2x.png",
            },
            accidental: {
                name: "Accidental",
                color: "#FF0000",
                icon: iconBase + "Accidental2x.png",
            },
        };

        for (var i = 0; i < data.length; i++) {
            markers[i].setOptions({ icon: { url: icons[data[i].type].icon, scaledSize: new google.maps.Size(60, 40) } });
            markers[i].setPosition(new google.maps.LatLng(data[i].latitude, data[i].longitude));
        }

    } catch (e) {

    }
}
function updateMarkers(dotNetObjectReference, data) {
   // console.log(JSON.stringify(data));
    setMapOnAll(map);
    deleteMarkers();
    const legend = document.getElementById("legend");
    map.controls[google.maps.ControlPosition.LEFT_BOTTOM].clear();
    map.controls[google.maps.ControlPosition.LEFT_BOTTOM].push(legend);
    const iconBase = "assets/icons/";
    const icons = {
        maintained: {
            name: "Maintained",
            color: "#00CB14",
            icon: iconBase + "Maintained2x.png",
        },
        periodic: {
            name: "Periodic",
            color: "#FF6F00",
            icon: iconBase + "Periodic2x.png",
        },
        emergency: {
            name: "Emergency",
            color: "#DFBB0B",
            icon: iconBase + "Emergency2x.png",
        },
        accidental: {
            name: "Accidental",
            color: "#FF0000",
            icon: iconBase + "Accidental2x.png",
        },
    };

    const features = [];

    data.forEach((datum) => {
//console.log(JSON.stringify(datum));
        const feature = {
            "position": new google.maps.LatLng(datum.latitude, datum.longitude),
            "type": datum.type,
            "number": datum.vehicleNumber,
            "driverName": datum.driverName
        };
        //console.log(JSON.stringify(feature));

        features.push(feature);
    });
    var infoWindows = [];
    features.forEach((feature) => {
        var marker = new google.maps.Marker({
            position: feature.position,
            label: {
                text: feature.number,
                color: "#FFFFFF",
                fontSize: "12px",
                fontWeight: "bold"
            },
            icon: { url: icons[feature.type].icon, scaledSize: new google.maps.Size(60, 40) },

            map: map,
        });
        const infowindow = new google.maps.InfoWindow({
            content: '<div id="content">'
                + '<div id="bodyContent">'
                + '<table class="table table-borderless">'
                + '<tr><td>Driver Name :</td><td>' + feature.driverName + '</td></tr>'
                + '<tr><td>Number of trips :</td><td>05</td></tr>'
                //+ '<tr><td>Fuel Consumed :</td><td>10 Ltr</td></tr>'
                + '<tr><td>KMs :</td><td>150 km</td></tr>'
                + '<table>'
                + '<p>Tyres replacement due in 500 KMs</p>'
                + ' <p>'
                + '<a class="btn text-white mr-2" style="background-color:#DFBB0B" href="javascript:emergencyDotNetFunc(\'' + feature.number.toString() + '\')"> EMERGENCY</a>'
                + '<a class="btn text-white mr-2" style="background-color:#FF0000" href="javascript:accidentalDotNetFunc(\'' + feature.number.toString() + '\')"> ACCIDENTAL</a>'
                + '<a class="btn text-white mr-2" style="background-color:#FF6F00" onclick="dailyDotNetFunc(\'' + feature.number.toString() + '\');"> DAILY</a>'
                + '</p>'
                + ' <h3 style="margin-left:30%;">'
                + '<a class="btn text-dark mr-2" style="border: 1px solid #adb5bd;width:70%;" href="javascript:historyDotNetFunc(\'' + feature.number.toString() + '\')">'
                + '<img style="margin-right: 5px; height:20px;" alt="Pic" src="assets/icons/History1x.png"/>History</a>'
                + '</h3>'
                + '</div>'
                + '</div>',
        });
        //add infowindow to array
        infoWindows.push(infowindow);

        marker.addListener('click', function () {
            for (var i = 0; i < infoWindows.length; i++) {
                infoWindows[i].close();
            }
            infowindow.open(map, marker);
            //setTimeout(function () { infowindow.close(); }, 5000);
        });
        markers.push(marker);
    });

    window.emergencyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber);
        dotNetObjectReference.invokeMethodAsync("Emergency_JSInvoked", vehicleNumber);
    };
    window.accidentalDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("Accidental_JSInvoked", vehicleNumber);
    };

    window.dailyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("Daily_JSInvoked", vehicleNumber);
    };
    window.historyDotNetFunc = (vehicleNumber) => {
        //alert(vehicleNumber)
        dotNetObjectReference.invokeMethodAsync("History_JSInvoked", vehicleNumber);
    };
}
// Sets the map on all markers in the array.
function setMapOnAll(map) {
    for (let i = 0; i < markers.length; i++) {
        markers[i].setMap(map);
    }
}
// Removes the markers from the map, but keeps them in the array.
function clearMarkers() {
    setMapOnAll(null);
}

// Shows any markers currently in the array.
function showMarkers() {
    setMapOnAll(map);
}

// Deletes all markers in the array by removing references to them.
function deleteMarkers() {
    clearMarkers();
    markers = [];
}

