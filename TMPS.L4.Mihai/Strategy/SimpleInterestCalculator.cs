using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Strategy
{
    class SimpleInterestCalculator : IInterestCalculator
    {
        public double CalculateInterest(double balance)
        {
            return balance * 0.02; // 2% interest
        }
    }
}
