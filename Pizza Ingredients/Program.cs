using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(' ').ToArray();
            var maxIngredientLenght = int.Parse(Console.ReadLine());
            int ingredientsCount = 0;
            var addedIngredients = new List<string>();
            for (int i = 0; i < ingredients.Length && ingredientsCount < 10; i++)
            {
                if (ingredients[i].Length == maxIngredientLenght)
                {
                    addedIngredients.Add(ingredients[i]);
                    Console.WriteLine("Adding {0}.",ingredients[i]);
                    ingredientsCount++;
                }
            }
            Console.WriteLine("Made pizza with total of {0} ingredients.",ingredientsCount);
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", addedIngredients));
        }
    }
}
