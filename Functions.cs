using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog_Demo
{
    internal class Functions
    {
        Bank bank = new Bank();

        string name;
        long account;
        double WithDraw, Deposit;

        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void DepositAmount()
        {
            Console.WriteLine("Enter A/C Holder Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number: ");
            account = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Amount Deposit to be Deposited: ");
            Deposit = Convert.ToInt32(Console.ReadLine());
            logger.Info("Deposited Amount: " + Deposit);

            bank.bal = bank.bal + Deposit;
            logger.Info("Account Balance: " + bank.bal);
        }

        public void WithdrawAmount()
        {
            Console.WriteLine("Enter A/C Holder Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number: ");
            account = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Withdrawn: ");
            WithDraw = Convert.ToInt32(Console.ReadLine());
            logger.Info("Withdrawn Amount: " + WithDraw);

            if (bank.bal >= WithDraw)
            {
                bank.bal = bank.bal - WithDraw;
                Console.WriteLine("Please, Collect your money.");
                logger.Info("Account Balance: " + bank.bal);

            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
                logger.Error("Insufficient Balance");
            }
        }

        public void DisplayInfo()
        {
            logger.Info("Account Details: ");

            Console.WriteLine("-----Account Details-----");
            Console.WriteLine("A/C Holder Name: {0}", name);
            logger.Info("A/C Holder Name: " + name);

            Console.WriteLine("Bank A/C Number: {0}", account);
            logger.Info("Bank A/C Number: " + account);

            Console.WriteLine("Account Balance: {0}", bank.bal);
            logger.Info("Account Balance: " + bank.bal);
        }
    }
}
