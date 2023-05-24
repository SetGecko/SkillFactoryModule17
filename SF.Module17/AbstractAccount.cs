using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Module17
{
    /// <summary>
    /// Обычный счет
    /// </summary>
    public abstract class AbstractAccount
    {
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public AbstractAccount(string accId, double initSum)
        {
            AccountId = accId;
            Balance = initSum;
        }
    }
}
}
