using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : Recipe
    {
        public void PrintRecipe(IPrintRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}