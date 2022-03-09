using System;

namespace Main_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operator(10,5));
        }

        public static int Operator(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Operator(int num1, int num2, string Sub)
        {
            return num1 - num2;
        }
        public static int Operator(int num1, int num2, int num3, string Div)
        {
            return num1 / num2;
        }
        public static string Operator(int num1, int num2, int num3, int num4, string Multi)
        {
            return num1 * num2 + " " + Multi;
        }
    }
}
