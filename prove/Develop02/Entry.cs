using System;
using System.Collections.Generic;

public class Entry
{
  
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }
    
    
    
    public Entry(string date, string prompt, string response,string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
        
    }

    public string GetDisplay()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}\n";
    }
}