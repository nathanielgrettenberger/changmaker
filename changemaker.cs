using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changemaker_revised
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.90);
            Console.ReadKey();
          
        }
        static void ChangeMaker(double amount)
        {
            Console.WriteLine("Change for " + amount + " is: ");
            //declare vars to store # of coins
            double quarters = 0;
            double dimes = 0;
            double nickels = 0;
            double pennies = 0;
            //test if amount is bigger than coin
            int amountC = Convert.ToInt32(amount * 100);
            quarters = (int)(amountC / 25);
            amountC = (amountC % 25);

            dimes = (int)(amountC / 10);
            amountC = (amountC % 10);

            nickels = (int)(amountC / 05);
            amountC = (amountC % 05);

            pennies = (int)(amountC / 01);
            amountC = (amountC % 01);

            //Output values
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennies);
        }
    }
}
