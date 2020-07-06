using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            while (j<101)
            {
                if (j % 3==0 && j % 5==0)
                {
                    Console.WriteLine("BuzzFizz");
                    Console.WriteLine(j);
                }
                if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.WriteLine(j);
                }
                if (j % 5 ==0)
                {
                    Console.WriteLine("Buzz");
                    Console.WriteLine(j);
                }
                j++;
            }
            // for (int i = 1; i < 256; i++)
            // {
            //     Console.WriteLine(i);
            // }
            
            // for (int j = 1; j <= 100; j++)
            // {
            //     if (j % 3==0 && j %5==0);
            //     {
            //         Console.WriteLine("BuzzFizz");
            //     }
            //     if (j % 3 == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //     }
            //     if (j % 5 ==0)
            //     {
            //         Console.WriteLine("Buzz");
            //     }
                
            // }
        }
    }
}
