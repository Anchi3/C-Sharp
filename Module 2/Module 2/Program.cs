using System;

namespace Module_2
{
    public class Program
    {

        public static string PrimeFactors(int number)
        {
            string res = string.Empty;

            for (int i = 2; i <= number; ++i)
            {
                while (number % i == 0)
                {

                    res += string.IsNullOrEmpty(res) ? i.ToString() : " x " + i;
                    number /= i;

                }
            }

            return res;
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Please enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"\nThe prime factors of {number} are: " 
                                + PrimeFactors(number));
            
            Console.WriteLine("\nThank you for using the Prime Number Factors calculator. " +
                                "Have a great day!!!");

           
        }


    }

    
}       

