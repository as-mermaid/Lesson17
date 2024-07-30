using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt<int> bankAcc1 = new BankAccaunt<int>();
            bankAcc1.Input();
            Console.WriteLine(bankAcc1.GetInfo());

            BankAccaunt<string> bankAcc2 = new BankAccaunt<string>();
            bankAcc2.Input();
            Console.WriteLine(bankAcc2.GetInfo());

            Console.ReadKey();
        }
    }
}
