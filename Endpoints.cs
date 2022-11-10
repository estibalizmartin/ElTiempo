namespace ElTiempo;

public class Endpoints
{
    public static string GetGeoapifyEndpoint(string? cityName)
    {
        return "https://api.geoapify.com/v1/geocode/search?text=" + cityName + "&format=json&apiKey=" + Config.GeoapifyKey;
    }

    public static string GetOpenMeteoEndpoint(double lon, double lat)
    {
        return "https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon + "&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
    }
}