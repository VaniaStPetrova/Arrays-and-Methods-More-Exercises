using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodsList = Console.ReadLine().Split(' ').ToList();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "done")
            {
                var commandList = command.Split(' ').ToList();
                var itemName = commandList[0];
                var qtyToOrder = long.Parse(commandList[1]);
                int indexOfGoods = goodsList.IndexOf(itemName);
                long goodsStock = indexOfGoods < quantities.Count ? quantities[indexOfGoods] :0;
                if (goodsStock >= qtyToOrder)
                {
                    var totalPrice = qtyToOrder * prices[indexOfGoods];
                    Console.WriteLine("{0} x {1} costs {2:F2}", goodsList[indexOfGoods], qtyToOrder, totalPrice);
                    quantities[indexOfGoods] -= qtyToOrder;
                }
                else
                {
                    Console.WriteLine("We do not have enough {0}", goodsList[indexOfGoods]);
                }
                command = Console.ReadLine();
            }
        }
    }
}
