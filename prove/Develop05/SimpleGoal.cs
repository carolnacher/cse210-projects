class SimpleGoal : Goal
{
    public SimpleGoal(string name,string description, int value) : base(name,description, value) { }

   public override void RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            Console.WriteLine();
            Console.WriteLine($"Good Job with -> {Name} <- Simple Goal. You do it!! gained {Value} points!");
        }
        else
        {
            Console.WriteLine($"This goal -> {Name} <- has already been completed. Recording additional events.");
        }
    }

}