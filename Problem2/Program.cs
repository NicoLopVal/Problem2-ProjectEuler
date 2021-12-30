using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            int value1 = 1;
            int value2 = 2;
            int sum = 2;

            while(value2 < 4000000)
            {
                int nextNum = value1 + value2;
                if (nextNum % 2 == 0)
                    sum = sum + nextNum;
                value1 = value2;
                value2 = nextNum;
            }

            Console.WriteLine("The sum is: " + sum);

        }
    }
}
