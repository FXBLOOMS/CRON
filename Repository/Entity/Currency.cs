using Kernel;
using System;
using System.Collections.Generic;
using System.Text;
using static Kernel.Enumerations;

namespace Repository.Entity
{
    public class Currency : ValueObject<Currency>
    {
        public CurrencyType CurrencyType { get; private set; }

        public decimal Amount { get; private set; }
    }
}
