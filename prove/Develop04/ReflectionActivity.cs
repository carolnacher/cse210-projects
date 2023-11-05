using System;

public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
         Description = "This reflective activity will help us to reach our full potential as a person.";
    }

    public string GenerateRandomPrompt()
    {
        
        string[] reflectionPrompts = 
        {
            "What are you grateful for today?",
            "What is a recent achievement you're proud of?",
            "What can you do to improve your well-being?",
            "How can you practice self-compassion today?",
            "What is a positive affirmation you can use?",
        };

        Random random = new Random();
        int index = random.Next(reflectionPrompts.Length);
        return reflectionPrompts[index];
    }

   public void DisplayReflectionQuestion(string question)
{
    if (Duration <= 0)
        {
        Console.WriteLine("Invalid duration. Please enter a positive number of seconds.");
        }
        else
        {
            SetDurationFromUserInput();
            for (int seconds = 0; seconds < Duration; seconds += 10)
            { 
                int second = Duration;
                
                Console.WriteLine();
                Console.WriteLine($"Take a moment to reflect on the following question: \n{question}");
                Console.WriteLine();
                Console.WriteLine("If you could think of something and you already feel ready, press Enter to continue.");
                Console.ReadLine();
                Console.WriteLine();

                
                DisplayCountdown("How did you feel when you finished? ", Duration);
                DisplaySpinner();
                DisplayCountdown("What was your favorite thing about this experience? ", Duration);
                DisplaySpinner();

            }     
        
Console.WriteLine();
Thread.Sleep(2000);
Console.WriteLine("Congratulations! You've completed the Reflecton Activity.");
Console.WriteLine();
DisplayEndMessage();    

       }
}




}
    
     
    
    

