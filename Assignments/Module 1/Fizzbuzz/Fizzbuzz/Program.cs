using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 1; j <= 100; ++j)
            {

                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }

                else if (j % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                else if (j % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                else
                {
                    Console.Write(j);
                }

                if (j == 100)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(", ");
                }

                if (j % 15 == 0)
                {
                    Console.Write("\n");
                }


            }

            Console.WriteLine("\n\nHave a great day!!!");

        }
    }

}