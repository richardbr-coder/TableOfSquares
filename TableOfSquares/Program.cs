using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double counter;
            const int maxValue = 20;
            double square;

            Console.WriteLine("Table Of Squares");
            Console.WriteLine("________________");
            Console.WriteLine("X     X-Square");
            Console.WriteLine("----------------");

            for (counter = 1; counter <= maxValue; counter++)
            {
                square = Math.Pow(counter, 2);
                Console.WriteLine("{0}        {1}", counter, square);
            }

            Console.ReadLine();
        }
    }
}
