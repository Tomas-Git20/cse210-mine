using System;

namespace EternalQuest
{
public class EternalGoal : Goal
{
private int _timesCompleted;

    public EternalGoal(
        string name,
        string description,
        int points,
        int timesCompleted = 0)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return Points;
    }

    public override bool IsComplete()
    {
        // Eternal goals can never be completed.
        return false;
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetSaveData()
    {
        return $"Eternal|{Name}|{Description}|{Points}|{_timesCompleted}";
    }
}

}
