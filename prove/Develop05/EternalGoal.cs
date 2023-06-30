using System;

public class EternalGoal:Goal {

	private int _recordedTimes;
	public EternalGoal():base(){
		this._recordedTimes = 0;
	}

	public void SetRecordedTimes(int times)
	{
		this._recordedTimes = times;
	}

	public int GetRecordedTimes()
	{
		return this._recordedTimes;
	}

	public override void ConfigureGoal()
	{
		SetType("eg");

		Console.Write("\nWhat is the name of your goal?: ");
		SetName(Console.ReadLine());

		Console.Write("What is a short description of it?: ");
		SetDescription(Console.ReadLine());

		Console.Write("What is the amount of points associated with this goal?: ");
		SetPoints(int.Parse(Console.ReadLine()));
		
		SetRecordedTimes(0);

		Console.WriteLine("Goal added!");
	}

	public override int GetEarnedPoints()
    {
			return GetPoints() * this._recordedTimes;
    }
	public override void CompleteGoal()
	{
		this._recordedTimes = this._recordedTimes + 1;
	}

	public override string FormatLine()
	{
		return $"{GetType()}\t{GetName()}\t{GetDescription()}\tfalse\t{GetPoints()}\tnull\tnull\tnull\t{GetRecordedTimes()}";
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
