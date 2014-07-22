var getWeather = function () {
    $.getJSON('https://api.forecast.io/forecast/4f5ddc4970c31afe753a70a6e3afc9c2/' + config.location.lat + ',' + config.location.lng + '?callback=?', function (data) {
        console.log(data);
        if (data.currently.precipIntensity > 0) {
            $('body').css({ 'background-image': 'url(../images/' + config.backgrounds.raining + ')' });
        }
    });
}
$(function () {
    $('body').css({ 'background-image': 'url(../images/' + config.backgrounds.default + ')' });
    setInterval(getWeather, 1000 * 60 * 30); // every 30 minutes
    getWeather();
});