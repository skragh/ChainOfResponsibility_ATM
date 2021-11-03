using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Payout payoutMagic = new Payout100(new Payout50(new Payout20(new Payout10(new Payout5(new Payout1())))));
            ATM automat = new ATM(payoutMagic);
            automat.StartUp();
        }
    }
}
