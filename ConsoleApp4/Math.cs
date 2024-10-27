
using System.Runtime.CompilerServices;

namespace ConsoleApp4
{
    internal class Math
    {
        public static double Addition() => A + B;

        public static double Subtraction() => A - B;

        public static double Division()
        {
            if (B == 0) { return 0.0; }
            return A / B;
        }

        public static double MultiPlication() => A * B;

        public static double Absolute()
        {
            return A < 0 ? -A : A;
        }

        public static void SetNums()
        {
            Console.WriteLine("Enter Nums");

            string A_String = Console.ReadLine();
            string B_String = Console.ReadLine();

            if (!double.TryParse(A_String, out A))
            {
                Console.WriteLine($"{A_String}-y tiv che.");
                return;
            }
            if (!double.TryParse(B_String, out B))
            {
                Console.WriteLine($"{B_String}-y tiv che.");
                return;
            }
        }

        public static void SetNum()
        {
            Console.WriteLine("Enter Num");

            string A_String = Console.ReadLine();

            if (!double.TryParse(A_String, out A))
            {
                Console.WriteLine($"{A_String}-y tiv che.");
                return;
            }
        }

        private static double A, B;
    }
}
