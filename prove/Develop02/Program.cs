using System;
using System.IO; 

/*
    Write a new entry
    Display the journal
    Save the journal to a file
    Load the journal from a file
    Provide a menu that allows the user choose these options
*/

class Program
{
    /*
    MAIN
    MAIN
    MAIN
    */
    static void Main(string[] args)
    {

        Journal _myJournal = new Journal();

        string selectedOption = ShowMenu();
        while (selectedOption != "5"){
            if (selectedOption == "1") {
                _myJournal = WriteEntry(_myJournal);
            } else if (selectedOption == "2") {
                _myJournal = DisplayJournal(_myJournal);
            } else if (selectedOption == "3") {
                _myJournal = LoadJournal(_myJournal);
            } else if (selectedOption == "4") {
                _myJournal = SaveJournal(_myJournal);
            } else {
                Console.WriteLine("You must select an option in order to proceed.");
            }
            selectedOption = ShowMenu();
        }
        Console.WriteLine("Bye!");
    }

    /*-----------------------------------------------------------------------------------------------*/
    /*-----------------------------------------------------------------------------------------------*/
    /*-----------------------------------------------------------------------------------------------*/

    /**/
    static string ShowMenu(){
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choises");
        Console.WriteLine("1 - Write");
        Console.WriteLine("2 - Display");
        Console.WriteLine("3 - Load");
        Console.WriteLine("4 - Save");
        Console.WriteLine("5 - Quit");
        Console.WriteLine("What would you like to do: ");
        return Console.ReadLine();
    }

    /**/
    static Journal WriteEntry(Journal myJournal){
        myJournal.AddEntry();
        return myJournal;
    }

    /**/
    static Journal DisplayJournal(Journal myJournal){
        myJournal.DisplayEntrys();
        return myJournal;
    }

    /**/
    static Journal LoadJournal(Journal myJournal){
        myJournal.ReadJournal();
        return myJournal;
    }

    /**/
    static Journal SaveJournal(Journal myJournal){
        myJournal.SaveJournal();
        return myJournal;
    }
}