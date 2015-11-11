using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = Utils.getSquareRect(44, 59);
            Console.WriteLine("New vers square:" + square);

            Console.WriteLine("press any key...");
            Console.ReadKey(); 
        }
    }
}
