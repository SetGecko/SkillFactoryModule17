using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SF.Module17
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<IInterest>
            {
                new Account("40802", 1000),
                new SalaryAccount("40817", 20000),
                new DepositAccount("42306", 100000)
            };

            Calculator.CalculateInterest(accounts);

            foreach (AbstractAccount acc in accounts)
                Console.WriteLine($"Счет №{acc.AccountId}, Баланс: {acc.Balance,10:F2}, Проценты: {acc.Interest,7:F2}");
        }
    }
}
