using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Module17
{
    class Calculator
    {
        public static void CalculateInterest(List<IInterest> accounts)
        {
            accounts.ForEach(acc => acc.CalculateInterest());
        }
    }
}
