using System;

class Program
{

	static void Main(string[] args)
	{
		string option = "0";
		List<Goal> goalsList = new List<Goal>();

		while (option != "6")
		{
			option = DisplayMainMenu(goalsList);
			if (option=="1")
			{
				goalsList.Add(CreateGoal());
			} 
			else if (option=="2")
			{
				DisplayGoals(goalsList, false);
			}
			else if (option=="3") 
			{
				SaveGoals(goalsList);
			}
			else if (option=="4") 
			{
				goalsList = ReadGoals();
			}
			else if (option=="5") 
			{
				RecordEvent(goalsList);
			}
			else if (option=="6")
			{
				Console.WriteLine("\n\nBye!");
				break;
			}
			else if((option != "1") && (option != "2") && (option != "3") && (option != "4") && (option != "5")){
				Console.WriteLine("Please select a valid option!");
				Console.ReadLine();
			}
			Console.WriteLine("\n(Press key to continue...)");
			Console.ReadLine();
		}
	}

	public static Goal CreateGoal()
	{
		string goalType = GetGoalOption();
		if(goalType=="1")
		{
			SimpleGoal sg = new SimpleGoal();
			sg.ConfigureGoal();
			return sg;
		}
		else if(goalType=="2")
		{
			EternalGoal eg = new EternalGoal();
			eg.ConfigureGoal();
			return eg;
		}
		else if (goalType=="3")
		{
			CheckListGoal cg = new CheckListGoal();
			cg.ConfigureGoal();
			return cg;
		}
		else {
			Console.WriteLine("Enter a valid option...");
			return null;
		}
	}


	public static List<Goal> ReadGoals()
	{
		try
		{
			Console.Write("Indicate name of the goals file: ");
			string filePath = Console.ReadLine();
			filePath = $"./{filePath}.tsv";
			List<Goal> goalsList = new List<Goal>();
			using (StreamReader reader = new StreamReader(filePath))
			{
				reader.ReadLine();
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] fields = line.Split('\t');
					if(fields[0]=="sg")
					{
						SimpleGoal g = new SimpleGoal();
						g.SetType(fields[0]);
						g.SetName(fields[1]);
						g.SetDescription(fields[2]);
						g.SetCompleted(bool.Parse(fields[3]));
						g.SetPoints(int.Parse(fields[4]));
						goalsList.Add(g);
					}
					else if(fields[0]=="eg")
					{
						EternalGoal g = new EternalGoal();
						g.SetType(fields[0]);
						g.SetName(fields[1]);
						g.SetDescription(fields[2]);
						g.SetCompleted(bool.Parse(fields[3]));
						g.SetPoints(int.Parse(fields[4]));
						goalsList.Add(g);
					}
					else if(fields[0]=="cg")
					{
						CheckListGoal g = new CheckListGoal();
						g.SetType(fields[0]);
						g.SetName(fields[1]);
						g.SetDescription(fields[2]);
						g.SetCompleted(bool.Parse(fields[3]));
						g.SetPoints(int.Parse(fields[4]));
						g.SetTotal(int.Parse(fields[5]));
						g.SetCurrent(int.Parse(fields[6]));
						g.SetBonus(int.Parse(fields[7]));
						goalsList.Add(g);
					}
				}
			}
			Console.WriteLine("Goals loaded!");
			return goalsList;
		}
		catch (System.IO.FileNotFoundException error)
		{
			Console.WriteLine("File not found...");
			List<Goal> gl = new List<Goal>();
			return gl;
		}
		
	}
	public static void SaveGoals(List<Goal> goals)
	{
		if(goals.Count > 0 )
		{
			Console.Write("Select file name where you want to save the goals (Just file name): ");
			string filePath = Console.ReadLine();
			filePath = $"./{filePath}.tsv";
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				writer.WriteLine("type\tname\tdescription\tcompleted\tpoints\tcg_total\tcg_current\tcg_bonus");
				foreach(Goal g in goals)
				{
					writer.WriteLine(g.FormatLine());
				}
			}
			Console.WriteLine("Goals saved");
		}
		else 
		{
			Console.WriteLine("No goals to save...");
		}
		
	} 

	public static List<Goal> RecordEvent(List<Goal> goalsList)
	{
		if(goalsList.Count > 0)
		{
			int index = DisplayGoals(goalsList, true);
			if(index > goalsList.Count) {
				Console.WriteLine("\nSelect a valid option!");
				return goalsList;
			}
			Goal selectedGoal = goalsList[index - 1];
			selectedGoal.CompleteGoal();
			goalsList[index - 1] = selectedGoal;
			Console.WriteLine("Recorded!");
			return goalsList;
		}
		else 
		{
			Console.WriteLine("No goals to check...");
			return null;
		}
		
	}

	public static void DisplayTotal(List<Goal> goals)
	{
		int total = 0;
		foreach (Goal g in goals)
		{
			total = total + g.GetEarnedPoints();
		}
		Console.WriteLine($"You have {total} points");
	}

	public static int DisplayGoals(List<Goal> goals, bool select)
	{
		if(goals.Count > 0)
		{
			Console.WriteLine("\nThe goals are: ");
			int index = 1;
			foreach (Goal g in goals)
			{
				g.DisplayGoal(index);
				index++;
			}
			if(select){
				Console.Write("Which goal did you accomplish?: ");
				return int.Parse(Console.ReadLine());
			}
		} 
		else 
		{
			Console.WriteLine("There are no goals to list...");
		}
		return 0;
	}

	public static string GetGoalOption()
	{
		Console.Clear();
		Console.WriteLine("What type of goal would you like to create?");
		Console.WriteLine("1 - SimpleGoal");
		Console.WriteLine("2 - EternalGoal");
		Console.WriteLine("3 - ChecklistGoal");
		Console.Write("Option: ");
		return Console.ReadLine();
	}

	public static string DisplayMainMenu(List<Goal> goalsList)
	{
		Console.Clear();
		DisplayTotal(goalsList);
		Console.WriteLine("\nMenu Options: ");
		Console.WriteLine("1 - Create new goal");
		Console.WriteLine("2 - List goals");
		Console.WriteLine("3 - Save goals");
		Console.WriteLine("4 - Load goals");
		Console.WriteLine("5 - Record Event");
		Console.WriteLine("6 - Quit\n\n");
		Console.Write("Select option: ");
		return Console.ReadLine();
	}
}
