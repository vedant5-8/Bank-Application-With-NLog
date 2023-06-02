using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Functions func = new Functions();

            while (true)
            {
                Console.WriteLine("\nPlease, Select any function ");
                Console.WriteLine("1. Deposit Amount");
                Console.WriteLine("2. Withdraw Amount");
                Console.WriteLine("3. Display Information");
                Console.WriteLine("4. Exit");
                Console.Write("=> ");

                int functions = Convert.ToInt32(Console.ReadLine());

                switch (functions)
                {
                    case 1:
                        func.DepositAmount();
                        break;
                    case 2:
                        func.WithdrawAmount();
                        break;
                    case 3:
                        func.DisplayInfo();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Select valid input.");
                        break;
                }
            }
        }
    }
}
