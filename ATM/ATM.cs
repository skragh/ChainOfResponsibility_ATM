using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATM
    {
        public Payout handler { get; set; }
        public ATM(Payout payoutHandler)
        {
            handler = payoutHandler;
        }
        public void StartUp()
        {
            Console.WriteLine("### Welcome to the ATM run by Chain of responsibility ###");
            Console.WriteLine("");
            var runProgram = "y";
            while (runProgram != "n")
            {
                //presentate commands
                Console.Write("For Money press y, to exit ATM press n: ");
                runProgram = Console.ReadLine();

                if(runProgram!="n")
                {
                    Console.Write("How much would you like to withdraw? ");
                    
                    try
                    {
                        var money = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Paying out {money} DKr.");
                        handler.ExchangeMoney(money);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }

            }
            
        }
    }
}
