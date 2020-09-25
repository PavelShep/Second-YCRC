using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Логический оператор & (и)
            bool k = (a * a >= 0) & (a * a < 0);
            Console.WriteLine(k);

            //Логический оператор | (или)
            bool k1 = (b * b >= 0) | (b * b < 0);
            Console.WriteLine(k1);

            //Строки
            string a1 = "hello";
            string b1 = "hi";
            bool k2 = (a * a >= 0) & (a1 == b1);
            bool k3 = (b * b >= 0) | (a1 == b1);
            Console.WriteLine(k2 + " " + k3);
            // Мы можем сравнивать строки только с помощью операций == !=, операции > < >= <= не работают.
            // Мы полноценно можем сравнивать лишь длину строк.

            //Сравнение двух чисел: a и b
            bool k4 = (a > b);
            Console.WriteLine(k4);
        }
    }
}
