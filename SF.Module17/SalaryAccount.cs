using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Module17
{
    /// <summary>
    /// Зарплатный счет
    /// </summary>
    public class SalaryAccount : AbstractAccount, IInterest
    {
        public SalaryAccount(string accId, double initSum) : base(accId, initSum)
        {

        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.02;
        }
    }
}
