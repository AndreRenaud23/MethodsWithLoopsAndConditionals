#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Numbers()
        {
            //1
            Console.WriteLine("Press enter to start the program");
            Console.ReadLine();
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);
            //2
            for (int i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine($"{i}");
            }


            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //3
            Console.WriteLine("Enter a number");
            var userInputNumber1 = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);

            Console.WriteLine("Enter a second number");
            var userInputNumber2 = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);

            while (true)
            {
                if (userInputNumber1 < userInputNumber2)
                {
                    Console.WriteLine($"{userInputNumber2} is greater than {userInputNumber1}");
                    break;
                }
                else if (userInputNumber1 > userInputNumber2)
                {
                    Console.WriteLine($"{userInputNumber1} is greater than {userInputNumber2}");
                    break;
                }
                else if (userInputNumber1 == userInputNumber2)
                {
                    Console.WriteLine($"{userInputNumber1} is equal to {userInputNumber2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Hmm, try again");
                }
            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //4
            Console.WriteLine("Enter a number");
            var userInputNumber3 = Convert.ToInt32(Console.ReadLine());
            
            
            if (userInputNumber3 % 2 == 0)
            {
                Console.WriteLine($"{userInputNumber3} is an even number");
                
            }
            else
            {
                Console.WriteLine($"{userInputNumber3} is an odd number");
            
            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //5

            Console.WriteLine("Enter a number");
            var userInputNumber4 = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(500);
            if (userInputNumber4 > 0)
            {
                Console.WriteLine($"{userInputNumber4} is a positive number");

            }
            else if (userInputNumber4 < 0)
            {
                Console.WriteLine($"{userInputNumber4} is a negative number");
            }
            else
            {
                Console.WriteLine($"{userInputNumber4} is neither a positive nor a negative number");

            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //6

            Console.WriteLine("How old are you");
            var userInputNumber5 = Convert.ToInt32(Console.ReadLine());

            if (userInputNumber5 >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are too young to vote!");
            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //7

            Console.WriteLine("Enter a number");
            var userInputNumber6 = Convert.ToInt32(Console.ReadLine());

            if (userInputNumber6 <= 10 && userInputNumber6 >= -10)
            {
                Console.WriteLine($"{userInputNumber6} is in the range of -10 to 10");
            }
            else
            {
                Console.WriteLine($"{userInputNumber6} is in the range of -10 to 10");
            }

            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(2000);

            //8

            Console.WriteLine("Enter a number");
            var userInputNumber7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table:");
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(userInputNumber7 * i);
            }


        }
    }
}




#endregion