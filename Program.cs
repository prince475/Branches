using System;
// using brings in other libraries that you could need and makes the scope of them even simpler.

namespace ConsoleApp6
// namespace are just used to group and organize code. especially when you have multiple different classes you may want
// to keep classes that are related in the same namespace just to keep everything organized.
{
    class Program
    {
        static void Main(string[] args)
        // this is our main method which we see as our entry point to the program. Tells the computer where the prog
        // starts. The main method also needs to be static so as not to change dynamically as the program is executing.
        // void is also a method. it could be anything you want your program to return eg int, string, for us it void.
        // Then we have a string array of arguments
        {
            Console.WriteLine("Hello, World!");
            string friend = "prince";
            Console.WriteLine($"Hello, {friend}");

            int a = 5;
            int b = 3;
            int c = 4;

            // any kind of if statements will have to return true or false.
            // to have multiple statements always add curly braces.
            // && and operator which combines the two basic conditions. equality operator everything should be true
            // || or operator(either one of the condition is satisfied)


            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is less than 10");
            }

             if ( (a + b + c > 10) && (a == b) )
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("and the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is less than 10");
                Console.WriteLine("or the first number is not equal to the second");

            }


        }
    }
}
