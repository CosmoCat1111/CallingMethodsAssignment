using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    

    class Program
            {
                static void Main()
                {
                    // get user input
                    Console.Write("Enter a number for me please: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    // instance for class
                    MathOperations operations = new MathOperations();

                    // methods
                    int result1 = operations.AddTen(userInput);
                    Console.WriteLine($"Adding 10 to your number gives: {result1}");

                    int result2 = operations.SubtractFive(userInput);
                    Console.WriteLine($"Subtracting 5 from your number gives: {result2}");

                    int result3 = operations.MultiplyByThree(userInput);
                    Console.WriteLine($"Multiplying your number by 3 gives: {result3}");
                    Console.ReadLine();
                }
            }

    
}

