using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.Write("Enter something: ");
            input = Console.ReadLine();
            Console.WriteLine(input);
        } while (input != "exit");

        Console.WriteLine("Closing program...");
    }
}
