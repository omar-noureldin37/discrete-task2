using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Start number: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("End numder: ");
            int e = int.Parse(Console.ReadLine());

            for (int x = s; x <= e; x++)
            {
                for (int y = 1; y < x; y++)
                {
                    if (x % y ==0)
                    {
                        sum += y; 
                    }
                }
                if (sum == x)
                {
                    Console.WriteLine(x);
                }
                sum = 0;
            }
            Console.WriteLine("_______________");


        }
    }
}
