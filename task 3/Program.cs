using System;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("1 - Квадрат");
            Console.WriteLine("2 - Круг");
            Console.WriteLine("3 - Прямокутник");
            Console.WriteLine("4 - Трикутник");
            Console.Write("вибір: ");

            string choice = Console.ReadLine().ToLower().Trim();

            switch (choice)
            {
                case "1":
                case "квадрат":
                    Console.Write("Введіть розмір сторони: ");
                    double side = double.Parse(Console.ReadLine());
                    double squareArea = side * side;
                    Console.WriteLine($"Площа квадрата = {squareArea}");
                    break;



                case "2":
                case "круг":
                    Console.Write("Введіть розмір радіуса: ");
                    double radius = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * radius * radius;
                    Console.WriteLine($"Площа круга = {circleArea}");
                    break;



                case "3":
                case "прямокутник":

                    Console.Write("Введіть розмір першої сторони: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введіть розмір другої сторони: ");
                    double b = double.Parse(Console.ReadLine());
                    double rectArea = a * b;
                    Console.WriteLine($"Площа прямокутника = {rectArea}");
                    break;



                case "4":
                case "трикутник":
                    Console.Write("Введіть розмір основи: ");
                    double baseLen = double.Parse(Console.ReadLine());
                    Console.Write("Введіть розмір висоти: ");
                    double height = double.Parse(Console.ReadLine());
                    double triangleArea = (baseLen * height) / 2;
                    Console.WriteLine($"Площа трикутника = {triangleArea}");
                    break;


                default:
                    Console.WriteLine("Невідома фігура.");
                    break;
            }
        }
    }
}