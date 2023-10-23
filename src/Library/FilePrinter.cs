using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintRecipe printerText)
        {
            File.WriteAllText("Recipe.txt", printerText.GetTextToPrint());
        }
    }
}