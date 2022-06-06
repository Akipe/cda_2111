using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BorrowCalc
{
    public class BorrowCalculation
    {
        public long AmountBorrowed { get; set; }
        public int AnnualRatePercent { get; set; }
        public int DurationInMonths { get; set; }
        public TimeFrequency RepaymentFrequency { get; set; }

        public int GetNumberRefund()
        {
            return DurationInMonths / (int)RepaymentFrequency;
        }

        public Decimal GetRefundAmount()
        {
            return RefundFormula();
        }

        // Formula : K * (t / (1 - (1 + t) pow (-n)))
        // K -> AmountBorrowed
        // t -> GetMonthlyRatePercent()
        // n -> GetNumberRefund()
        private Decimal RefundFormula()
        {
            return (decimal)(
                AmountBorrowed * (GetRatePercentFromFreqency() / (1 - Math.Pow(1 + GetRatePercentFromFreqency(), -GetNumberRefund())))
            );
        }

        private double GetRatePercentFromFreqency()
        {
            return AnnualRatePercent / (int)RepaymentFrequency / 100;
        }
    }
}
