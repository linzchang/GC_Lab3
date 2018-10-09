using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Hello, what is your name?");
            string userName = Console.ReadLine();

            while (true)
            { 
                try
                {
                    //Prompt user to enter a number between 0 and 100
                    Console.WriteLine(userName + ", please enter a number between 0 and 100: ");
                    int userInput = int.Parse(Console.ReadLine());

                    //Display associated result based on input received

                    //if odd and greater than 60 print number entered and odd
                    if (userInput > 100 || userInput <= 0)
                    {
                        Console.WriteLine("That number is either too large or too small.");
                        continue;
                    }
                    else if (userInput % 2 != 0 && userInput > 60)
                    {
                        Console.WriteLine(userName + " entered " + userInput + ". This number is Odd, and it is greater than 60.");
                    }
                    //if odd, print number entered and odd
                    else if (userInput % 2 != 0)
                    {
                        Console.WriteLine(userName + " entered " + userInput + ". This number is Odd.");
                    }
                    //if even and in range 2-25 print "even and less than 25"
                    else if (userInput % 2 == 0 && userInput <= 25)
                    {
                        Console.WriteLine(userName + " this number is Even, and less than 25.");
                    }
                    //if even and in range 26-60 print "even"
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine(userName + " this number is Even.");
                    }
                    //if even and greater than 60 print number entered and even
                    else if (userInput % 2 == 0)
                    {
                        Console.WriteLine(userName + " entered " + userInput + ". This number is Even.");
                    }

                    Console.WriteLine("Would you like to continue? Y/N");
                    char userAnswer = Console.ReadKey().KeyChar;
                    if (Char.ToUpper(userAnswer) == 'N')
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid number.");
                    continue;
                }
                
            }
        }
    }
}
