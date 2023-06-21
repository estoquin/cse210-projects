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
                
            }
            else if (option=="4") 
            {
                
            }
            else if (option=="5") 
            {
                RecordEvent(goalsList);
            }
            else if((option != "1") && (option != "2") && (option != "3") && (option != "4") && (option != "5")){
                Console.WriteLine("Please select a valid option! (Press any key to continue)");
                Console.ReadLine();
            }

            option = Console.ReadLine();
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

    public static List<Goal> RecordEvent(List<Goal> goalsList)
    {
        int index = DisplayGoals(goalsList, true);
        Goal selectedGoal = goalsList[index - 1];
        selectedGoal.SetCompleted(true);
        goalsList[index - 1] = selectedGoal;
        return goalsList;
    }

    public static void DisplayTotal(List<Goal> goals)
    {
        int total = 0;
        foreach (Goal g in goals)
        {
            if(g.GetCompleted())
            {
                total = total + g.GetPoints();
            }
        }
        Console.WriteLine($"You have {total} points");
    }

    public static int DisplayGoals(List<Goal> goals, bool select)
    {
        Console.WriteLine("\nThe goals are: ");
        int index = 1;
        foreach (Goal g in goals)
        {
            g.DisplayGoal(index);
            index++;
        }
        if(select){
            Console.WriteLine("Which goal did you accomplish?: ");
            return int.Parse(Console.ReadLine());
        }
        return 0;
    }

    public static string GetGoalOption()
    {
        Console.Clear();
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1 - SimpleGoal");
        Console.WriteLine("2 - EternalGoal");
        Console.WriteLine("3 - ChecklistGoal");
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
        Console.WriteLine("6 - Quit");
        return Console.ReadLine();
    }
}