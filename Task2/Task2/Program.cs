using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double balance = 1000.00;

           
        
            while (true) 
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3.Withdraw Money");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter your choice.");
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice.Please try again");
                    continue;

                  
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Account Balance:" + balance);
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to be deposited");
                        if(double.TryParse(Console.ReadLine(), out double deposit) && deposit>0)
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit is Successful.Your balance is:" + balance);

                        }
                        else 
                        {
                            Console.WriteLine("invalid amount");

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter amount to be withdraw");
                        if(double.TryParse(Console.ReadLine(),out double withdraw)&& withdraw>0)
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal is successfull");
                            Console.WriteLine("Balance is :" + balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Amount");
                            Console.WriteLine("Amount is" + balance);
                        }
                            break;
                        
                    case 4:
                        Console.WriteLine("Your choice is option 4");
                        Environment.Exit(0);
                        break;

                        default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }


                Console.ReadLine();
            }


        }
    }
}
