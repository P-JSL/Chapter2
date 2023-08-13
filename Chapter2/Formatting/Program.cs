using System.Diagnostics.Tracing;
using static System.Console;

namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
                ) ;

            string formatted = string.Format(format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            Console.WriteLine( $"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

            //키입력 받기
            Write("Press any key cobination : ");
            ConsoleKeyInfo key = ReadKey();

            WriteLine();
            WriteLine("Key : {0}, Char: {1}, Modifers : {2}", arg0: key.Key, arg1:key.KeyChar, arg2 : key.Modifiers);


        }
    }
}