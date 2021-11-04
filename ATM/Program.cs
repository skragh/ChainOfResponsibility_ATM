using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //example with all handlers insert
            IPayout payoutMagic = new Payout100(new Payout50(new Payout20(new Payout10(new Payout5(new Payout1())))));
            ATM automat = new ATM(payoutMagic);
            automat.StartUp();

            //paying out only bills -> cannot handle coins
            Console.Clear();
            Console.WriteLine("ATM can now only handle bills (50/100)");
            IPayout payoutOnlyBills = new Payout100(new Payout50());
            ATM automatOnlyBills = new ATM(payoutOnlyBills);
            automatOnlyBills.StartUp();
            
            
            
        }
    }
}
