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

	public void SetTotal(int total)
	{
		this._total = total;
	}

	public int GetBonus()
	{
		return this._bonus;
	}

	public void SetBonus(int bonus)
	{
		this._bonus = bonus;
	}

	public int GetCurrent()
	{
		return this._current;
	}

	public void SetCurrent(int current)
	{
		this._current = current;
	}

	public override void ConfigureGoal()
	{
		SetType("cg");

		Console.Write("\nWhat is the name of your goal?: ");
		SetName(Console.ReadLine());

		Console.Write("What is a short description of it?: ");
		SetDescription(Console.ReadLine());

		Console.Write("What is the amount of points associated with this goal?: ");
		SetPoints(int.Parse(Console.ReadLine()));

		Console.Write("How many times does this goal need to be acomplished for a bonus?: ");
		SetTotal(int.Parse(Console.ReadLine()));

		Console.Write("What is the bonus for accomplishing it that many times?: ");
		SetBonus(int.Parse(Console.ReadLine()));

		Console.WriteLine("Goal added!");
	}

	public override int GetEarnedPoints()
    {
		int total = 0;
		total = total + this._current * GetPoints();
		if(GetCompleted())
		{
			total = total + GetBonus();
		}
		return total;
    }

	public override void CompleteGoal()
	{
		this._current = this._current + 1;
		if(this._current == this._total)
		{
			SetCompleted(true);
		}
	}

	public override string FormatLine()
	{
		return $"{GetType()}\t{GetName()}\t{GetDescription()}\t{GetCompleted()}\t{GetPoints()}\t{GetTotal()}\t{GetCurrent()}\t{GetBonus()}";
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
