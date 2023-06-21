using System;

public class CheckListGoal:Goal{

    private int _total;
    private int _current;
    private int _bonus;

    public CheckListGoal():base(){

    }

    public int GetTotal()
    {
        return this._total;
    }

    public void SetTotal()
    {
        Console.WriteLine("How many times does this goal need to be acomplished for a bonus?: ");
        this._total = int.Parse(Console.ReadLine());
    }

    public void SetBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times?: ");
        this._bonus = int.Parse(Console.ReadLine());
    }

    public int GetCurrent()
    {
        return this._current;
    }

    public void SetCurrent()
    {
        Console.Write("Current: ");
        this._current = int.Parse(Console.ReadLine());
    }

    public override void ConfigureGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        SetTotal();
        SetBonus();
    }

    public override void DisplayGoal(int index)
    {
        string name = GetName();
        string description = GetDescription();
        string completed = " ";
        int total = GetTotal();
        int current = GetCurrent();

        if (GetCompleted()){
            completed = "X";
        }
        Console.WriteLine($"{index} - [{completed}] {name} ({description}) -- Currently completed: {current}/{total}");
    }
}