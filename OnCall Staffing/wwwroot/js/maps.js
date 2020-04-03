
    var map;
    var infoWindow;

    var request;
    var service;
    var markers = [];

    function initialize() {
        var center = new google.maps.LatLng(39.953131, -82.981683);
        map = new google.maps.Map(document.getElementById('map'), {
            center: center,
            zoom: 12
        });
            request = {
            location: center,
            radius: 80467,
            types: ['hospitals']
        };
        infoWindow = new google.maps.InfoWindow();

        service = new google.maps.places.PlacesService(map);

        service.nearbySearch(request, callback);

        google.maps.event.addListener(map, 'rightclick', function(event) {
            map.setCenter(event.latLng)
            clearResults(markers)

            var request = {
                location: event.latLng,
                radius: 80467,
                types: ['hospitals']
            };
            service.nearbySearch(request, callback);
        })
    }

    function callback(results, status) {
        if(status == google.maps.places.PlacesServiceStatus.OK){
            for (var i = 0; i < results.length; i++){
                markers.push(createMarker(results[i]));
            }
        }
    }

    function createMarker(place) {
        var placeLoc = { lat: 39.9947, lng: 83.0172 }
        var marker = new google.maps.Marker({
            position: placeLoc,
            map: map,
            title: 'Grant Medical Center',
            label: "My fave hosp"
        });

        google.maps.event.addListener(marker, 'click', function() {

            infoWindow.setContent(place.name);
            infoWindow.open(map, this);
        });
        return marker;
    }

    function clearResults(markers) {
        for (var m in markers) {
            markers[m].setMap(null)
        }
        markers = []
    }

    google.maps.event.addDomListener(window, 'load', initialize);
    