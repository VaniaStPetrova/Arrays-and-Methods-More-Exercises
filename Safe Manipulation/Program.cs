﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine().Split(' ').ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    wordsList.Reverse();
                }
                else if (command[0] == "Distinct")
                {
                    var changeCheck = new List<string>(wordsList);
                    wordsList = wordsList.Distinct().ToList();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if (0 <= index && index < wordsList.Count)
                    {
                        var replacingWord = command[2];
                        wordsList[index] = replacingWord;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
