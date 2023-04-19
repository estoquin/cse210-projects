using System;

class Program
{
    static void Main(string[] args)
    {
        char play = 'n';
        do {
            Console.Clear();
            int random_number = new Random().Next(1, 100);
            int guessInteger;
            int attepmts = 1;
            do {
                Console.Write("What is your guess?: ");
                guessInteger = int.Parse(Console.ReadLine());
                if ( guessInteger !=  random_number ) {
                    if ( guessInteger >  random_number ){
                        Console.WriteLine("Lower");
                    } else {
                        Console.WriteLine("Higher");
                    }
                    attepmts++;
                }
            } while ( guessInteger !=  random_number);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Attempts: {attepmts}");
            Console.WriteLine("Play again? [y/n]");
            play = Console.ReadKey().KeyChar;
        } while ( play.Equals('y') );
        
    }
}