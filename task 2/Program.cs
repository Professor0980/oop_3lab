using System;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("введіть текст: ");
            string text = Console.ReadLine();

            Console.Write("скільки слів треба видалити ?> (X): ");
            int x = int.Parse(Console.ReadLine());

            string[] words = text.Split(' ');

            if (x >= words.Length)
            {
                Console.WriteLine("hезультат: ");
            }
            else
            {
                string result = string.Join(" ", words, x, words.Length - x); ;
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
}