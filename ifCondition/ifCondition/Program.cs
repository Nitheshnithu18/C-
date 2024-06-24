using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 15.5;
            if(a > b)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("Ais smaller than B");
                Console.ReadLine();
            }
        }
    }
}
