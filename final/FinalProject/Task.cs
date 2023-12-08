using System;
using System.Collections.Generic;

class Task
{
    public string Name { get; }
    public int Point { get; }
    public bool IsComplete { get; protected set; }

    public Task(string name, int point, bool isComplete = false)
    {
        Name = name;
        Point = point;
        IsComplete = isComplete;
    }

    public virtual void Perform()
    {
        if (!IsComplete)
        {
            MarkComplete();
        }
        else
        {
            Console.WriteLine($"Now you are ready to continue with other activities.");
        }
    }

    public void MarkComplete()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Well done!! You get {Point} points");
        }
    }

    protected virtual void Complete()
    {
        Console.WriteLine($"Default implementation of {Name} task completed! {Point} points");
        MarkComplete();
    }
}