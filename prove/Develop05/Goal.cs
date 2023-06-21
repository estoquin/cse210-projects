using System;

public abstract class Goal {

    private string _name;
    private string _description;
    private int _points;
    private bool _completed;

    public Goal()
    {
        // this._name = name;
        // this._description = description;
        // this._points = points;
        // this._completed = false;
    }

    public bool GetCompleted()
    {
        return this._completed;
    }

    public string GetName()
    {
        return this._name;
    }

    public string GetDescription()
    {
        return this._description;
    }

    public void SetCompleted(bool completed)
    {
        this._completed = completed;
    }

    public void SetName()
    {
        Console.WriteLine("What is the name of your goal?: ");
        this._name = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal?: ");
        this._points = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return this._points;
    }

    public void SetDescription()
    {
        Console.WriteLine("What is a short description of it?: ");
        this._description = Console.ReadLine();
    }

    public abstract void DisplayGoal(int index);

    public abstract void ConfigureGoal();
}