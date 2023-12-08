if("geolocation" in navigator)
{
    navigator.geolocation.getCurrentPosition(function (position)
    {
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;
        
        //atualiza os elementos HTML com as coordenadas 
        document.querySelector('#latitude').textContent = latitude;
        document.querySelector('#longitude').textContent = longitude;
        
        //cria um mapa leaflet com as coordenadas de geolocalização
        var map = L.map('map').setView([latitude, longitude], 15);

        //adiciona camadas de mapa a partir de openStreetMap
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
                }).addTo(map);

       //adiciona um marcador com pop-up no mapa
       L.marker([latitude, longitude]).addTo(map)
             .bindPopup("sua localização atual")
             .openPopup();

      });
}
else{
    //nao suporta geolocalizacao
    alert("Geolocalização não é suportada pelo navegador");
}