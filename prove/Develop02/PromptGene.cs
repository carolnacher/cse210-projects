using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> journalPrompts;
    private Random random;

    public PromptGenerator()
    {
        // Initialize the list of prompts
        journalPrompts = new List<string>
        {
            "What are three things you're grateful for today, and why?",

            "Describe a recent challenge you faced and how you overcame it.",

            "Write scripture that had a significant impact on you and why.",

            "What are your top three personal goals, and what steps are you taking to achieve them?",

            "Describe a person who has influenced your life in a positive way and why they're important to you.",

            "Reflect on a recent mistake or failure. What did you learn from it, and how will you use that to think in a celestial way?",

            "Write about a place you've always wanted to visit and why it holds significance for you.",

            "Explore a hobby or interest that brings you joy and write about your experiences and passion for it.",

            "What are your favorite self-care activities, and how do they help you recharge and maintain balance in your life?", 

            "Write a letter to your future self, expressing your hopes, dreams, and goals for the coming years.",

            "Reflect on a time when you stepped out of your comfort zone. What did you gain from that experience?",

            "Describe a moment of pure happiness or contentment that you've experienced recently.",

            "Write about a meaningful conversation you had with someone recently and how it impacted your perspective.",

        };

        // Initialize a random number generator
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        // Get a random index to select a random prompt
        int randomIndex = random.Next(journalPrompts.Count);
        return journalPrompts[randomIndex];
    }
}
