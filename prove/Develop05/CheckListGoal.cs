class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int Bonus { get; set; }
    protected int currentCount;
    public int CurrentValueBonus { get; private set; }

    public ChecklistGoal(string name, string description, int value, int targetCount, int bonus) : base(name, description, value)
    {
        TargetCount = targetCount;
        Bonus = bonus; 
        currentCount = 0;
        CurrentValueBonus = 0;
                
    }
        public override void Display()
    {
        string completionStatus;

        if (Completed)
            {
                completionStatus = $"Completed {currentCount}/{TargetCount} times";
            }
        else
            {
                completionStatus = $"{currentCount}/{TargetCount} times ";
            }
        Console.WriteLine();
        Console.WriteLine($"[{(Completed ? "X" : " ")}] {Name} - {Description} ({completionStatus})");
    }

    public override void RecordEvent()
    {
        if (currentCount < TargetCount)
        {
            currentCount++;
            Console.WriteLine();
            Console.WriteLine($"You have completed {Name}. You gained {Value} points!");

            if (currentCount == TargetCount)
            {            
                Completed = true;
                
                Console.WriteLine($"Congratulations! {Name} it's completed {TargetCount} You earned a bonus!");
                CurrentValueBonus += Bonus;
                Console.WriteLine($"Bonus added! New Target Count: {TargetCount}");
            }
            else
            {
                Console.WriteLine($"You are closer to the goal {Name} - {currentCount}/{TargetCount} times. Keep going!");
            }
        }
        else
        {
            Console.WriteLine($"{Name} has already been completed the required number of times. Recording additional events.");
        }
    }
    }