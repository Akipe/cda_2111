namespace BorrowCore
{
    public static class BorrowCalculation
    {
        public static long CapitalBorrow { get; set; }
        public static int AnnualRatePercent { get; set; }
        public static int DurationInMonths { get; set; }
        public static TimeFrequency RepaymentFrequency { get; set; }

        public static int GetNumberRefund()
        {
            return DurationInMonths / (int)RepaymentFrequency;
        }

        public static Decimal GetRefundAmount()
        {
            return RefundFormula();
        }

        // Formula : K * (t / (1 - (1 + t) pow (-n)))
        // K -> CapitalBorrow
        // t -> GetMonthlyRatePercent()
        // n -> GetNumberRefund()
        private static Decimal RefundFormula()
        {
            return (decimal)(
                CapitalBorrow * (GetRatePercentFromFreqency() / (1 - Math.Pow(1 + GetRatePercentFromFreqency(), -GetNumberRefund())))
            );
        }
        static private double GetRatePercentFromFreqency()
        {
            return AnnualRatePercent / (int)RepaymentFrequency / 100;
        }
    }
}