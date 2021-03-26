using System;

namespace VariableExercise_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;
            int dogAge;
            bool dogYears;
            string dogYorN;

            Console.WriteLine("What is your dog's name?");
            dogName = Console.ReadLine();

            Console.WriteLine($"How old is {dogName} in human years?");
            dogAge = int.Parse(Console.ReadLine()); //this line will take string input from user and convert it to a int

            //how to convert the input of yes or no to True or False? 
            Console.WriteLine($"Do you want to know how old {dogName} is in dog years? Yes or No?");
            dogYorN = Console.ReadLine();

            if (dogYorN == "yes") // how to account for other answers "Yes", "ye", etc
            {
                Convert.ToBoolean(true);
                Console.WriteLine(7 * dogAge);
                dogYears = true;
            }
            else
            {
                Convert.ToBoolean(false);
                Console.WriteLine("What ev...");
                dogYears = false;
            }
        }
    }
}
