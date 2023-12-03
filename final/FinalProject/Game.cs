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
        Console.WriteLine("Performed Tasks:");
        foreach (var task in performedTasks)
        {
            Console.WriteLine($"{task.Name}: {task.Point} points");
        }

        Console.WriteLine($"Total Score: {totalPoint} points");
    }
}
