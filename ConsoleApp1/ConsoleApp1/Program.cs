using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            math math1 = new math();
            Console.WriteLine(math1.pow(2, 4));


        }

    }


    class math
    {

        public int pow(int num, byte power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total * num;
            }
            return total;
        }
        public double pow(double num, double power)
        {
            double total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total * num;
            }
            return total;
        }
        public int kok(int num, int power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total / num;
            }
            return total;
        }
    }
}
