﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
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
                int indexOfGoods = goodsList.IndexOf(command);
                Console.WriteLine("{0} costs: {1}; Available quantity: {2}", goodsList[indexOfGoods], prices[indexOfGoods], quantities[indexOfGoods]);
                command = Console.ReadLine();
            }
        }
    }
}
