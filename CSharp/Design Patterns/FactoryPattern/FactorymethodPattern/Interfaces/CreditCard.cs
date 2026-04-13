using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern.Interfaces
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharges();
    }
}
