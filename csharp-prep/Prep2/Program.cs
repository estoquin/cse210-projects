using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?: ");
        string value = Console.ReadLine();
        int p = int.Parse(value);
        string finalLetter = "";

        if ( p >= 90 ){
            finalLetter = "A";
        } else if ( p >= 80 ) {
            finalLetter = "B";
        } else if ( p >= 70 ) {
            finalLetter = "C";
        } else if ( p >= 60 ) {
            finalLetter = "D";
        } else {
            finalLetter = "F";
        }

        // Extra points! :D
        int lastDigit = -1;
        string sign = "";
        if ( p > 10 ) {
            lastDigit = p % 10;
        }
        if ( (lastDigit >= 7) && (p < 97)) {
            sign = "+";
        } else  if ( ( lastDigit < 3 ) && ( p> 60 )) {
            sign = "-";
        } else {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {finalLetter}{sign}");

        if ( p >= 70 ) {
            Console.WriteLine("Congrats! you made it!.");
        } else {
            Console.WriteLine("Let's try again! you can do it!.");
        }
    }
}