namespace SuperMarket
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{base.ToString()}/n Value to pay:{ValueToPay()}";
        }
    }
}
