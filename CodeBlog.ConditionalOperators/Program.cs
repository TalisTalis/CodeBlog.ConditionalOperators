using System;

namespace CodeBlog.ConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");

            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine();

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"Наибольшее число из них: {firstNumber}");
            }
            else if (secondNumber > thirdNumber)
            {
                Console.WriteLine($"Наибольшее число из них: {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число из них: {thirdNumber}");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine();

            switch (firstNumber % 2)
            {
                case 0 : Console.WriteLine($"Первое число {firstNumber} чётное");
                    break;
                case 1:
                    Console.WriteLine($"Первое число {firstNumber} нечётное");
                    break;
                default:
                    break;
            }

            switch (secondNumber % 2)
            {
                case 0:
                    Console.WriteLine($"Второе число {secondNumber} чётное");
                    break;
                case 1:
                    Console.WriteLine($"Второе число {secondNumber} нечётное");
                    break;
                default:
                    break;
            }

            switch (thirdNumber % 2)
            {
                case 0:
                    Console.WriteLine($"Третье число {thirdNumber} чётное");
                    break;
                case 1:
                    Console.WriteLine($"Третье число {thirdNumber} нечётное");
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine();

            Console.WriteLine(firstNumber < 100 ? $"Первое число {firstNumber} меньше 100" : $"Первое число {firstNumber} больше или равно 100");
            Console.WriteLine(secondNumber < 100 ? $"Второе число {secondNumber} меньше 100" : $"Второе число {secondNumber} больше или равно 100");
            Console.WriteLine(thirdNumber < 100 ? $"Третье число {thirdNumber} меньше 100" : $"Третье число {thirdNumber} больше или равно 100");

        }
    }
}
