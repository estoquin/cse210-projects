using System;

/*
Standard details - 
Lists the title, description, date, time, and address.

Full details - 
Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.

Short description - 
Lists the type of event, title, and the date.
*/


class Program
{
    static void Main(string[] args)
    {

        string description;

        // This lines are for console preatty printing only....
        // Please do not take away points because of this!!
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.Clear();
     
        Address a1 = new Address("Av. Belgrano 2138", "San Miguel de Tucuman", "Tucuman", "Argentina");
        description = "To work with date and time in C#, create an object of the DateTime";
        LectureEvent le = new LectureEvent("The Misterys of the Cosmos", description, a1, "Stephen Hawkings", 90);
        le.SetDate(2023,07,15,15,30);
        le.SimpleDetails();
        le.GenerateFullMessage();
        le.GenerateShortMessge();

        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

        Address a2 = new Address("Pje. Ceballos 1360", "San Salvador", "Jujuy", "Chile");
        description = "RSVP is an acronym that stands for Répondez s'il vous plaît, which is a French phrase that translates to ";
        ReceptionEvent re = new ReceptionEvent("My Wedding with Carla", description, a2, "nicolasWedding@gmail.com");
        re.SetDate(2023,12,01,10,00);
        re.SimpleDetails();
        re.GenerateFullMessage();
        re.GenerateShortMessge();
        

        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


        Address a3 = new Address("200 Park Ave", "New York", "NY", "USA");
        description = "Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address";
        OutdoorEvent oe = new OutdoorEvent("Mountain Climbing!", description, a3, "Sunny");
        oe.SetDate(2023,02,25,07,30);
        oe.SimpleDetails();
        oe.GenerateFullMessage();
        oe.GenerateShortMessge();


        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
    }
}