using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(userName, square);
    }

    /* ------------------------------------------------------------------------------------------------------- */
    /* ------------------------------------------------------------------------------------------------------- */
    /* ------------------------------------------------------------------------------------------------------- */

    /*
    * @description
    */
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }


    /*
    * @description
    */
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    /*
    * @description
    */
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    /*
    * @description
    */
    static int SquareNumber(int n) {
        return n * n;
    }

    /*
    * @description
    */
    static void DisplayResult(string name, int square) {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}