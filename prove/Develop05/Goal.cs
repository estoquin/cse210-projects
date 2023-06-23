using System;

public abstract class Goal {

	private string _name;
	private string _description;
	private int _points;
	private bool _completed;
	private string _type; // sg, eg, cg

	public Goal()
	{

	}

	public bool GetCompleted()
	{
		return this._completed;
	}

	public void SetCompleted(bool completed)
	{
		this._completed = completed;
	}

	public string GetName()
	{
		return this._name;
	}

	public void SetName(string name)
	{
		this._name = name;
	}

	public string GetDescription()
	{
		return this._description;
	}

	public void SetDescription(string description)
	{
		this._description = description;
	}


	public string GetType()
	{
		return this._type;
	}

	public void SetType(string type)
	{
		this._type = type;
	}

	public void SetPoints(int points)
	{
		this._points = points;
	}

	public int GetPoints()
	{
		return this._points;
	}

	
	public abstract void CompleteGoal(); 

	public abstract void DisplayGoal(int index);

	public abstract void ConfigureGoal();

	public abstract string FormatLine();

	public abstract int GetEarnedPoints();
}
