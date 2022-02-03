// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#btnSearchCity").click(function () {

    var cityName = $("#city").val();
    if (cityName != "") {
        $.ajax({
            type: "GET",
            url: "/Home/WeatherData?city=" + cityName + "&lang=" + 'de',
            success: function (response) {
                setValues(response);
            },
            error: function () {
                setValues(undefined);
                alert("Die Eingabe ist ungültig!");
            }
        });
    }
    else {
        alert("Bitte geben Sie eine Stadt ein!");
    }
});

function setValues(response) {

    $("#cityName").text(response ? response.City : "");
    $("#currentTemp").text(response ? response.Temp : "");
    $("#air").text(response ? response.Pressure : "");
    $("#hum").text(response ? response.Humidity : "");
    $("#lowTemp").text(response ? response.MinTemp : "");
    $("#highTemp").text(response ? response.MaxTemp : "");
    $("#highTemp").text(response ? response.MaxTemp : "");
    $("#windDir").text(response ? response.WindDeg : "");
    $("#windSpeed").text(response ? response.WindSpeed : "");
    $("#country").text(response ? ", " + response.Country : "");
    $("#icon").attr("src", response ? "http://openweathermap.org/img/w/" + response.Icon + ".png" : "");
    $("#icon").css({ "visibility": response ? "visible" : "hidden" });
    $("#description").text(response ? response.Description : "");
}
