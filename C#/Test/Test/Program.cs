using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] trying = new int[2][];

            trying[1][1] = 123;
            Console.WriteLine(trying[1][1]);
        }
    }
}
