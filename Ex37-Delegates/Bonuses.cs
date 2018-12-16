using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37_Delegates
{
    public class Bonuses
    {
        public double TenPercent(double amount)
        {
            return 10;
        }
        public double FlatTwoIfAmountMoreThanFive(double amount)
        {
            return 0;
        }
    }
}
