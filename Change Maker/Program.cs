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
            ChangeMaker(1.84);

            Console.ReadKey();
        }

        static void ChangeMaker (double amount)
        {
            var tracker = amount;
            var quarters = 0;
            var dimes = 0;
            var nickels = 0;
            var pennies = 0;

            while (tracker > 0)
            {
                if (tracker >= 0.25)
                {
                    quarters += 1;
                    tracker -= 0.25;

                    tracker = Math.Round(tracker, 2);
                }
                else if (tracker >= 0.1)
                {
                    dimes += 1;
                    tracker -= 0.1;

                    tracker = Math.Round(tracker, 2);
                }

                else if (tracker >= 0.05)
                {
                    nickels += 1;
                    tracker -= 0.05;

                    tracker = Math.Round(tracker, 2);
                }

                else if (tracker >= 0.01)
                {
                    pennies += 1;
                    tracker -= 0.01;

                    tracker = Math.Round(tracker, 2);
                }
            }

            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennies);
        }
    }
}
