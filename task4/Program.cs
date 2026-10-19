using System;
using System.Text;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("текст: ");
            string inputText = Console.ReadLine();

            char[] chars = inputText.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int position = i + 1;

                if (position % 15 == 0)
                {
                    chars[i] = '?';
                }
                else if (position % 3 == 0)
                {
                    chars[i] = 'X';
                }
                else if (position % 5 == 0)
                {
                    chars[i] = '9';
                }
            }

            string result = new string(chars);
            Console.WriteLine($"результат: {result}");
        }
    }
}