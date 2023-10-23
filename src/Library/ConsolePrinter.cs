using System;
using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter

    {
        public void PrintRecipe(IPrintRecipe printerText)
        {
            Console.WriteLine(printerText.GetTextToPrint());
        }
    }
}