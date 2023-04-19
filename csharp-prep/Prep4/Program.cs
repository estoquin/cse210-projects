using System;

class Program
{
    static void Main(string[] args)
    {
        int numbers = -1;
        int sum = 0;
        int smallestPositive = -1;
        float average = 0;
        int largets = -9999;
        List<int> numbersList = new List<int>();
        do {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());
            numbersList.Add(numbers);
            sum += numbers;
            average = sum / numbersList.Count;
            if ( numbers > largets ){
                largets = numbers;
            }
            if ( numbers > 0 ) {
                if ( (smallestPositive == -1) || ( numbers < smallestPositive ) ){
                    smallestPositive = numbers;
                }
            }
        } while ( numbers != 0 );

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largets}");
        Console.WriteLine($"The smallest positive is: {smallestPositive}");

        // Sort
        numbersList.Sort();
        foreach (int x in numbersList){
            Console.WriteLine(x);
        }
    }
}