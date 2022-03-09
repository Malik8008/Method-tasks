using System;

namespace Main_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //if (num < 50)
            //    for (int i = 1; i < num; i++)
            //    {
            //        if (i % 3 == 0)
            //            count++;
            //    }
            //else if (num > 50 && num < 100)
            //    for (int i = 1; i < num; i++)
            //    {
            //        if (i % 5 == 0)
            //            count++;
            //    }
            //else
            //    for (int i = 1; i < num; i++)
            //    {
            //        if (i % 8 == 0)
            //            count++;
            //    }
            //    Console.WriteLine(count);

            Console.WriteLine(Divides(205, 8));
        }

        public static int Divides(int num, int div)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % div == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
