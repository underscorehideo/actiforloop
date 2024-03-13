using System;

namespace taskTwo
{
    class Prgrm
    {
        static void Main(string[] args)
        {
            int i1;
           

            for (i1 = 1; i1 <= 100; i1++)
            {

                if (i1 % 4 == 0 || i1 % 6 == 0)
                {
                    Console.WriteLine("These numbers are divisible by 4 and 6: " + i1);
                }
            }

        }
    }
}