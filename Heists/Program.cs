using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
             var lootPricese = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var jewelsPrice = lootPricese[0];
            var goldPrice = lootPricese[1];
            double totalMoney = 0;
            var commandString = Console.ReadLine();
            while (commandString != "Jail Time")
            {
                var heistElements = 
                    commandString
                    .Split(' ')
                    .ToArray();
                int jewelsQuantity = heistElements[0].Where(ch => ch == '%').Count();
                int goldQuantity = heistElements[0].Where(ch => ch == '$').Count();
                var currentHeistCost = double.Parse(heistElements[1]);
                totalMoney += 
                    (jewelsQuantity * jewelsPrice) +
                    (goldQuantity * goldPrice) -
                    currentHeistCost;
                commandString = Console.ReadLine();
            }

            Console.WriteLine(totalMoney < 0 ? "Have to find another job. Lost: {0}." : "Heists will continue. Total earnings: {1}.", Math.Abs(totalMoney), totalMoney);            
        }
    }
}
