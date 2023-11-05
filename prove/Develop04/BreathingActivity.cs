using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
         
        Description = "This activity will help you to reduce stress in the body. This is because when you breathe deeply, your body sends a message to your brain to calm down and relax.";
    
    }




    
    public void PerformBreathingExercise()
    {   
        
    Console.WriteLine();
    SetDurationFromUserInput();
    Console.WriteLine();
    
    
        
        if (Duration <= 0)
        {
        Console.WriteLine("Invalid duration. Please enter a positive number of seconds.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Get ready to start the breathing exercise.");
            Thread.Sleep(2000);
            Console.WriteLine();


            
            for (int seconds = 0; seconds < Duration; seconds += 10)
            {
                
                int second = 5;
                string inhaleMessage = "Inhale deeply... ";
                DisplaySpinner();
                ContDown(inhaleMessage, second);
                Console.SetCursorPosition(0, Console.CursorTop + 1);  
                string exhaleMessage = "Breathe out.. ";
                DisplaySpinner();
                ContDown(exhaleMessage, second);
                Console.SetCursorPosition(0, Console.CursorTop + 1); 
                Console.WriteLine();
                
            }

        Console.WriteLine();
        Thread.Sleep(1500);

       
    }
    
     Console.WriteLine();
     Console.WriteLine("Congratulations! You've completed the Breathing Activity.");
     Console.WriteLine();
     DisplayEndMessage();
     
    
    }

}
