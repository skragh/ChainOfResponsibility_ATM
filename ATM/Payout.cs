using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    abstract class Payout
    {
        public Payout nextPayout { get; set; }
        public Payout(Payout payout=null)
        {
            nextPayout = payout;
        }

        public abstract void ExchangeMoney(int money);

        public void print(int currency,int moneyLeft)
        { Console.WriteLine($"{currency} DKr Payed out, money left to be payed:{moneyLeft}"); }

    }

    class Payout100 : Payout
    {
        private int responsibility = 100;
        public Payout100(Payout payout = null) : base(payout)
        {
        }

        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying out possible 100 DKr bills");
            //Handle what is this class' responsibility
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }

    class Payout50 : Payout
    {
        private int responsibility = 50;
        public Payout50(Payout payout = null) : base(payout)
        {
        }

        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying out possible 50 DKr bills");
            //Handle what is this class' responsibility
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }

    class Payout20 : Payout
    {
        private int responsibility = 20;
        public Payout20(Payout payout = null) : base(payout)
        {
        }

        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying out possible 20 DKr coins");
            //Handle what is this class' responsibility
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }

    class Payout10 : Payout
    {
        private int responsibility = 10;
        public Payout10(Payout payout = null) : base(payout) { }
        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying out possible 10 DKr coins");
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }

    class Payout5 : Payout
    {
        private int responsibility = 5;
        public Payout5(Payout payout = null) : base(payout) { }
        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying out possible 5 DKr coins");
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }


    class Payout1 : Payout
    {
        private int responsibility = 1;
        public Payout1(Payout payout=null) : base(payout) { }
        public override void ExchangeMoney(int money)
        {
            Console.WriteLine("Paying possible out 1 DKr coins");
            while (money >= responsibility)
            {
                money -= responsibility;
                print(responsibility, money);
            }
            //send request to next in chain, if more is to be done.
            if (money > 0)
                nextPayout.ExchangeMoney(money);
        }
    }
}

