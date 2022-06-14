namespace BorrowCore
{
    public class BorrowCalculation
    {
        public int CapitalBorrow { get; set; }
        public int AnnualRatePercent { get; set; }
        public int DurationInMonths { get; set; }
        public TimeFrequency RepaymentFrequency { get; set; }

        public BorrowCalculation()
        {
            Reset();
        }

        public int GetNumberRefund()
        {
            return DurationInMonths / (int)RepaymentFrequency;
        }

        public double GetRefundAmount()
        {
            return RefundFormula();
        }

        public void Reset()
        {
            CapitalBorrow = 0;
            AnnualRatePercent = 0;
            DurationInMonths = 0;
            RepaymentFrequency = TimeFrequency.Monthly;
        }

        // Formula : K * (t / (1 - (1 + t) pow (-n)))
        // K -> CapitalBorrow
        // t -> AnnualRatePercent
        // n -> GetNumberRefund()
        private double RefundFormula()
        {
            double K = CapitalBorrow;
            double t = GetAnualRateCompareFrequency();
            double n = GetNumberRefund();

            return K * (t / (1.0 - Math.Pow(1.0 + t, -n)));
        }

        private int GetHowManyRefundPerYear()
        {
            return (int)(12 / (int)RepaymentFrequency);
        }

        private double GetAnualRateCompareFrequency()
        {
            return ((double)AnnualRatePercent / 100.0) / GetHowManyRefundPerYear();
        }
    }
}