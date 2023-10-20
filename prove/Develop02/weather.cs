using System;
using System.IO;


public class Weather
{
    public string Location { get; set; }
    
    public double Temperature { get; set; }

    public Weather(string location, double temperature)
    {
        Location = location;
        Temperature = temperature;
    }
}