using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(x);
                if (x == 0)
                {
                    x = 1;
                }
                else
                {
                    int z = x;
                    x = x + y;
                    y = z;
                }
           }
            Console.ReadLine();
        }

    }
}
