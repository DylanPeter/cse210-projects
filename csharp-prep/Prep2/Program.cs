using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        
        string letter = "";

        if (percent >= 90)
        {
            // Console.WriteLine("Congrats! Your grade is an A! ");
            letter = "A";
        }
        
        else if (percent >= 80)
        {
            // Console.WriteLine("Congrats! Your grade is an B! ");
            letter = "B";
        }
        
        else if (percent >= 70)
        {
            // Console.WriteLine("Your grade is a C");
            letter = "C";
        }

        else if (percent >= 60)
        {
            // Console.WriteLine("Your grade is a D :( ");
            letter = "D";
        }
        
        else
        {
            // Console.WriteLine("Unfortunately, you got an F :( ");
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunetly, you didn't pass the class :(. Make sure to study harder next time!");
        }
    }
}