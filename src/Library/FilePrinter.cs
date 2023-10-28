using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipie irecipe)
        {
            File.WriteAllText("Recipe.txt", irecipe.GetTextToPrint());
        }
    }
}