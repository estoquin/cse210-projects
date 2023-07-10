using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Av. Belgrano 2138", "San Miguel de Tucuman", "Tucuman", "Argentina");
        LectureEvent le = new LectureEvent("The Misterys of the Cosmos", "To work with date and time in C#, create an object of the DateTime", "LE", a1, "Stephen Hawkings", 90);
        le.SetDate(2023,07,15,15,30);
        le.GenerateSimpleMessage();
        le.GenerateFullMessage();
        le.GenerateShortMessge();
    }
}