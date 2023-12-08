class Game
{
    private List<Task> performedTasks;
    private int totalPoint;

    public Game()
    {
        performedTasks = new List<Task>();
        totalPoint = 0;
    }

    public void PerformTask(Task task)
    {
        task.Perform();
        performedTasks.Add(task);
        totalPoint += task.Point;
    }

    public void ShowScore()
    {
        Console.WriteLine("Your score is:");
        
        {
           Console.WriteLine($"Total Score: {totalPoint} points");
        }

        
    }
     public void DisplayCountdown(string message, int seconds)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} seconds... ");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        Console.WriteLine();
    }
    
}