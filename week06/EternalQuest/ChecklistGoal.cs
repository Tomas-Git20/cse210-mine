using System;

namespace EternalQuest
{
public class ChecklistGoal : Goal
{
private int _amountCompleted;
private int _targetAmount;
private int _bonus;


    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetAmount,
        int bonus,
        int amountCompleted = 0)
        : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _targetAmount)
        {
            Console.WriteLine("This checklist goal is already complete.");
            return 0;
        }

        _amountCompleted++;

        int earned = Points;

        if (_amountCompleted == _targetAmount)
        {
            earned += _bonus;

            Console.WriteLine(
                $"Congratulations! You earned an additional {_bonus} bonus points!"
            );
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";

        return $"{check} Completed {_amountCompleted}/{_targetAmount} times";
    }

    public override string GetSaveData()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{_targetAmount}|{_bonus}|{_amountCompleted}";
    }
}

}
