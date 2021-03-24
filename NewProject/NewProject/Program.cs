using System;

namespace NewProject
{
    class Program
    {

        private static NLog.Logger _logger =
            NLog.LogManager.GetCurrentClassLogger();

        public static void SomeMethod()
        {
            _logger.Info("Hello Nlogger!");
        }

        static void Main(string[] args)
        {
            bool? b = null; // primitive types cannot be null... add ? to become nullable
            int? a = null;

            


            string result;
            int x = 20, y = 15;
            result = (x > y) ? "x greater than y" : "x less than y"; // ternary operator =  condition ? if true : if false
            
            Console.Write(result + "\n");


            SomeMethod();

            try
            {
                int p = 77;
                int q = 0;

                int res = p / q;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Something wrong happened");
            }

        }
    }
}
