using System;

public class SimpleGoal:Goal{


    public SimpleGoal():base() {

    }

    public override void ConfigureGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    public override void DisplayGoal(int index)
    {
        string name = GetName();
        string description = GetDescription();
        string completed = " ";
        if (GetCompleted()){
            completed = "X";
        }
        Console.WriteLine($"{index} - [{completed}] {name} ({description})");
    }
}