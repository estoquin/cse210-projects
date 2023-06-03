using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment ma = new MathAssignment("Nicolas Estoquin", "Fractions", "4.2", "7-19");
        WritingAssignment wa = new WritingAssignment("Juan Estoquin", "European History", "The Causes of World War II");

        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}