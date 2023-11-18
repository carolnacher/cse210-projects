
using System.Text.Json;
class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Eternal Goal");
        Console.WriteLine();
        

        Console.Write("Enter the number corresponding to the goal type: ");
        if (int.TryParse(Console.ReadLine(), out int goalTypeChoice))
        {
            Console.WriteLine();
            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a short description of the goal: ");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the value (points) associated with this goal: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the target count for the Checklist Goal: ");
            int targetCount = int.Parse(Console.ReadLine());
            if (targetCount == 0)
                {
                    goals.Add(new SimpleGoal(name, description, value));
                }
                else
                {
                    int bonus = 300;
                    goals.Add(new ChecklistGoal(name, description, value, targetCount,bonus));
                }

            switch (goalTypeChoice)
            {
                case 1:
                    goals.Add(new SimpleGoal(name, description,value));
                    break;
                case 2:
                    goals.Add(new EternalGoal(name,description, value));
                    break;
                case 3:
                    int bonus = 300;
                    goals.Add(new ChecklistGoal(name, description,  value, targetCount, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    public void DisplayGoals()
        {
            Console.WriteLine();
            Console.WriteLine("Current Goals:");
            

            foreach (Goal goal in goals)
            {
                goal.Display();
            }
        }

    public void RecordEvent()
    {   
        Console.WriteLine();
        Console.Write("Enter the name of the goal you completed: ");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

       if (goal != null)
        {
            goal.RecordEvent();
            score += goal.Value;

            
            if (goal is ChecklistGoal checklistGoal)
            {
                score += checklistGoal.Bonus;
                Console.WriteLine($"Bonus added! New Score: {score}");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine();
        Console.WriteLine($"Your current score is: {score} points");
    }

    public void SaveGoals()
    {
        try
        {
            Console.WriteLine();
            string fileName = $"goals_{DateTime.Now:yyyy-MM-dd}."; 
            string json = JsonSerializer.Serialize(goals, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);
            Console.WriteLine();
            Console.WriteLine($"This Goals were saved successfully to {fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("Goals loaded successfully.");
    }
}