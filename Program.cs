using System;
using System.Linq;

namespace Project
{
	public static class Program
	{
		public static void Main()
		{
int x, y, z = 0;



            Console.WriteLine("n1:-");

            x = int.Parse(Console.ReadLine());

            Console.WriteLine("n2:-");

            y = int.Parse(Console.ReadLine());

 

            for (int i = x; i < y; i++)

            {

                for (int j = 1; j < y; j++)

                {

                    if (i % j == 0)

                    {

                        z++;

                    }

                }

                if (z == 2)

                {

                    Console.WriteLine(i);

                }

                z = 0;

            }

            Console.ReadKey();
		}
	}
}