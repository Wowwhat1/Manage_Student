using System;

namespace _1618
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempNumber = Console.ReadLine();

            PrintResult(ValidationInput(tempNumber));
        }

        static uint ValidationInput(string tempNumber)
        {
            uint number;
        CheckPoint:
            bool checkInput = uint.TryParse(tempNumber, out uint result);
            if (checkInput)
            {
                number = (uint.Parse(tempNumber));
                return number;
            }
            else
            {
                Console.WriteLine("Retype: ");
                tempNumber = Console.ReadLine();
                goto CheckPoint;
            }
        }

        static void PrintResult(uint number)
        {
            for (int i = 1; i <= number; i++)
            {
                int eachNumber = i;
                SumOfEachNumber(number, eachNumber);
                if (CheckSpecialNumber(number, eachNumber))
                    Console.WriteLine($"{i} => True");
                else
                    Console.WriteLine($"{i} => False");
            }
        }

        static int SumOfEachNumber(uint number, int eachNumber)
        {
            int modulo, sum = 0;
            while (eachNumber != 0)
            {
                modulo = eachNumber % 10;
                eachNumber /= 10;
                sum += modulo;
            }
            return sum;
        }

        static bool CheckSpecialNumber(uint number, int eachNumber)
        {
            return SumOfEachNumber(number, eachNumber) == 5 || SumOfEachNumber(number, eachNumber) == 7 || SumOfEachNumber(number, eachNumber) == 11;
        }
    }
}
