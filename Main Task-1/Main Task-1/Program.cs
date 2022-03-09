using System;

namespace Main_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //int a = number % 7;
            //int b = 7 - a;
            //if (number%7==0)
            //{
            //    Console.WriteLine("7-e bolunur");
            //}
            //else if (a>b)
            //{
            //    Console.WriteLine(number+b);
            //}
            //else
            //{
            //    Console.WriteLine(number-a);
            //}


            Console.WriteLine(Divide(26));
        }

        public static int Divide(int num)
        {

            if (num % 7 == 0)
            {
                Console.WriteLine("7-e bolunur");
            }
            int a = num % 7;
            int b = 7 - a;
            if (a > b)
            {
                return num + b;
            }
            else
            {
                return num - a;
            }
        }
    }
}
