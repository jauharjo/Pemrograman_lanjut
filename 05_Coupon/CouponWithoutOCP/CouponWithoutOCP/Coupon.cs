namespace CouponWithoutOCP
{
    class Coupon
    {
        public double discNominal = 0;
        public double discPercentage = 0;
        public double discCashback = 0;
        public double priceNett(double originPrice)
        {
            double net = 0;
            if (discNominal == 0 && discPercentage > 0)
            {
                net = (100 - discPercentage) * originPrice / 100;
            }
            else if (discNominal > 0 && discPercentage == 0)
            {
                net = originPrice - discNominal;
            }
            else if (discNominal > 0 && discPercentage > 0)
            {
                net = originPrice - discNominal;
            }

            return net;
        }
    }
}
