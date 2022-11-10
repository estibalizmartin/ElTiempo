﻿namespace ElTiempo.Model;

public class Daily
{
    public List<string> time { get; set; }
    public List<int> weathercode { get; set; }
    public List<double> temperature_2m_max { get; set; }
    public List<double> temperature_2m_min { get; set; }
}

public class DailyUnits
{
    public string time { get; set; }
    public string weathercode { get; set; }
    public string temperature_2m_max { get; set; }
    public string temperature_2m_min { get; set; }
}

public class Hourly
{
    public List<string> time { get; set; }
    public List<double> temperature_2m { get; set; }
}

public class HourlyUnits
{
    public string time { get; set; }
    public string temperature_2m { get; set; }
}

public class WeatherModel
{
    public double latitude { get; set; }
    public double longitude { get; set; }
    public double generationtime_ms { get; set; }
    public int utc_offset_seconds { get; set; }
    public string timezone { get; set; }
    public string timezone_abbreviation { get; set; }
    public double elevation { get; set; }
    public HourlyUnits hourly_units { get; set; }
    public Hourly hourly { get; set; }
    public DailyUnits daily_units { get; set; }
    public Daily daily { get; set; }
}