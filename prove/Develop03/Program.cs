using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("1 Nefi", 3, 7);
        Scripture s = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", r1);

        string userInput = "";
        while (userInput != "quit"){
            Console.Clear();
            s.DisplayScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if(s.AllHidden()){
                break;
            } else {
                s.HideRandomWord();
            }
        }

    }
}