using System;

namespace _1618
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want: ");
            string tempNumber = Console.ReadLine();

            Console.WriteLine("Result: ");
            PrintResult(ValidateInput(tempNumber));
        }

        static uint ValidateInput(string tempNumber)
        {
        CheckPoint:
            bool isInputTrue = uint.TryParse(tempNumber, out uint number);
            if (isInputTrue && number != 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input! Retype: ");
                tempNumber = Console.ReadLine();
                goto CheckPoint;
            }
        }

        static uint SumOfDigit(uint eachNumber)
        {
            uint modulo, sum = 0;
            while (eachNumber != 0)
            {
                modulo = eachNumber % 10;
                eachNumber /= 10;
                sum += modulo;
            }
            return sum;
        }

        static bool IsSpecialNumber(uint eachNumber)
        {
            return SumOfDigit(eachNumber) == 5 || SumOfDigit(eachNumber) == 7 || SumOfDigit(eachNumber) == 11;
        }

        static void PrintResult(uint number)
        {
            for (uint i = 1; i <= number; i++)
            {
                uint eachNumber = i;
                SumOfDigit(eachNumber);
                if (IsSpecialNumber(eachNumber))
                    Console.WriteLine($"{i} => True");
                else
                    Console.WriteLine($"{i} => False");
            }
        }
    }
}
