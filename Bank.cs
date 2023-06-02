using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog_Demo
{
    internal class Bank
    {
        private double balance = 100000;

        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
