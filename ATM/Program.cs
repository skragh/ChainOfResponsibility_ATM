using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Payout payoutMagic = new Payout100(new Payout50(new Payout20(new Payout10(new Payout5(new Payout1())))));
            payoutMagic.ExchangeMoney(589);
        }
    }
}
