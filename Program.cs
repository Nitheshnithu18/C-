using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user name");
            string username=Console.ReadLine();
            Console.WriteLine("Enter password");
            string password=Console.ReadLine();
            Console.WriteLine("UserName:" + username);
            Console.WriteLine("Password:" + password);
            Console.ReadLine();
        }
    }
}
