using System;

namespace EternalQuest
{
public class SimpleGoal : Goal
{
private bool _complete;

    public SimpleGoal(
        string name,
        string description,
        int points,
        bool complete = false)
        : base(name, description, points)
    {
        _complete = complete;
    }

    public override int RecordEvent()
    {
        if (_complete)
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

        _complete = true;
        return Points;
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetStatus()
    {
        return _complete ? "[X]" : "[ ]";
    }

    public override string GetSaveData()
    {
        return $"Simple|{Name}|{Description}|{Points}|{_complete}";
    }
}

}
