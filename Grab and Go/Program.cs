using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var findLastNum = long.Parse(Console.ReadLine());
            if (numArray.Contains(findLastNum))
            {
                int index = 0;
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i] == findLastNum)
                    {
                        index = i;
                    }
                }
                Console.WriteLine(numArray.Take(index).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
