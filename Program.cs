using System;

namespace MyFirstApp
{
    class ProgramEasy
    {
        static void Main(string[] args)
        {
            // Exercise 1 Easy
            Console.WriteLine("Hello World, this is Lucian!");
            Console.WriteLine("-------------------------------------");
            // Exercise 2 Easy
            try
            {
                Console.WriteLine("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number introduced: {num} is even.");
                }
                else
                {
                    Console.WriteLine($"The number introduced: {num} is odd.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You need to introduce a number.");
            }
            // Exercise 3 Easy
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter one of the following options: ");
            Console.WriteLine("+ \n - \n * \n /");

            int divResult = num2 != 0 ? num1 / num2 : 0;

            int[] Results = { num1 + num2, num1 - num2, num1 * num2, divResult };
            string answer = Console.ReadLine();
            if (answer == "+")
            {
                Console.WriteLine($"Your result is: {num1} + {num2} = {Results[0]}");
            }
            else if (answer == "-")
            {
                Console.WriteLine($"Your result is: {num1} - {num2} = {Results[1]}");
            }
            else if (answer == "*")
            {
                Console.WriteLine($"Your result is: {num1} * {num2} = {Results[2]}");
            }
            else if (answer == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Undefined.");
                }
                else
                {
                    Console.WriteLine($"Your result is: {num1} / {num2} = {Results[3]}");
                }
            }
            // Exercise 4 Easy
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Guess a random number between 0 and 100:");
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            Console.WriteLine($"{randomNumber}");
            int guessedNumber = -1;
            while (guessedNumber != randomNumber)
            {
                Console.WriteLine("Enter your guess: ");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You guessed the number");
                    break;
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("The guess is too high.");
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("The guess is too low.");
                }
            }
            // Exercise 5 Easy
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Please enter a number from 1 to 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] multiplicationTable = {number * 0,number * 1,number * 2,number * 3,number * 4,number * 5,number * 6,number * 7,
                number * 8,number * 9,number * 10
            };
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                Console.WriteLine(multiplicationTable[i]);
            }
        }
    }
}