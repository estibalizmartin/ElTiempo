namespace ElTiempo;

public class Endpoints
{
    public static string GetGeoapifyEndpoint(string cityName)
    {
        return "https://api.geoapify.com/v1/geocode/search?text=" + cityName + "&format=json&apiKey=" + Config.GeoapifyKey;
    }
}