
namespace Nums
{
    internal class Numbering
    {
        public static void AddNumbering(int number)
        {
         
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"#{number}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
