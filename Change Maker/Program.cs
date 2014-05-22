using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //passing in an amount
            ChangeMaker(1.84);
            Console.WriteLine();
            ChangeMaker(3.76);
            Console.WriteLine();
            ChangeMaker(2.33);
            Console.ReadKey();
        }

        static void ChangeMaker (double amount)
        {
            //setting variables
            var tracker = amount;
            var quarters = 0;
            var dimes = 0;
            var nickels = 0;
            var pennies = 0;

            //have loop run until the amount that is passed is 0
            while (tracker > 0)
            {
                if (tracker >= 0.25)
                {
                    //adding .25 to quarter tracker
                    quarters += 1;
                    //subtracting .25 from total amount passed in
                    tracker -= 0.25;

                    //rounding tracker to the 2 nearest decimals
                    tracker = Math.Round(tracker, 2);
                }
                else if (tracker >= 0.1)
                {
                    //adding .1 to dime tracker
                    dimes += 1;
                    //subtracting .1 from total amount passed in
                    tracker -= 0.1;

                    //rounding tracker to the 2 nearest decimals
                    tracker = Math.Round(tracker, 2);
                }

                else if (tracker >= 0.05)
                {
                    //adding .5 to nickel tracker
                    nickels += 1;
                    //subtracting .5 from total amount passed in
                    tracker -= 0.05;

                    //rounding tracker to the 2 nearest decimals
                    tracker = Math.Round(tracker, 2);
                }

                else if (tracker >= 0.01)
                {
                    //adding .01 to penny tracker
                    pennies += 1;
                    //subtracting .01 from total amount passed in
                    tracker -= 0.01;

                    //rounding tracker to the 2 nearest decimals
                    tracker = Math.Round(tracker, 2);
                }
            }

            //printing out amount of each coin to the console
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennies);
        }
    }
}
