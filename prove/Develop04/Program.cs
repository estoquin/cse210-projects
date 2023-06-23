using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while (option != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1 - Start breathing activity");
            Console.WriteLine("\t2 - Start reflecting activity");
            Console.WriteLine("\t3 - Start listing activity");
            Console.WriteLine("\t4 - Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if(option=="1")
            {
                string name = "Breathing";
                string description = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum ";
                BreathingActivity ba = new BreathingActivity(name, description);
                ba.StartActivity();
            } else if (option == "2")
            {
                string name = "Reflecting";
                string description = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum ";
                ReflectingActivity ra = new ReflectingActivity(name, description);
                ra.StartActivity();
            } else if (option == "3")
            {
                string name = "Listing";
                string description = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum ";
                ListingActivity la = new ListingActivity(name, description);
                la.StartActivity();
            } else 
            {
                if ((option != "1") && (option!="2") && (option!="3") && (option!="4"))
                {
                    Console.WriteLine("Insert a valid option!");
                    Thread.Sleep(3000);
                }
            }
        }
    }

    
}
