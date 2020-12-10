namespace CouponWithOCP
{
    class CouponWithNominal : Coupon
    {
        public double discNominal;
        public CouponWithNominal(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }
}
