using System;

public class SimpleGoal:Goal{


	public SimpleGoal():base() {

	}

	public override void ConfigureGoal()
	{
		SetType("sg");

		Console.Write("\nWhat is the name of your goal?: ");
		SetName(Console.ReadLine());

		Console.Write("What is a short description of it?: ");
		SetDescription(Console.ReadLine());

		Console.Write("What is the amount of points associated with this goal?: ");
		SetPoints(int.Parse(Console.ReadLine()));

		Console.WriteLine("Goal added!");
	}

    public override int GetEarnedPoints()
    {
		if(GetCompleted())
		{
			return GetPoints();
		}
		else 
		{
			return 0;
		}
    }

	public override void CompleteGoal()
	{
		SetCompleted(true);
	}

	public override string FormatLine()
	{
		return $"{GetType()}\t{GetName()}\t{GetDescription()}\t{GetCompleted()}\t{GetPoints()}\tnull\tnull\tnull\tnull";
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
