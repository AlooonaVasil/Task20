using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            
            MyDelegate myDelegate = Сircumference;
            double d = myDelegate(r);
            Console.WriteLine($"Длина окружности {d:0.00}");

            myDelegate = CircleSquare;
            double s = myDelegate(r);
            Console.WriteLine($"Площадь круга {s:0.00}");

            myDelegate = BallVolume;
            double v = myDelegate(r);
            Console.WriteLine($"Объем шара {v:0.00}");

            Console.ReadKey();
        }

        static double Сircumference(double r) => 2.0 * Math.PI * r;
        static double CircleSquare(double r) => Math.PI* Math.Pow(r,2);
        static double BallVolume(double r) =>  4/3 * Math.PI* Math.Pow(r, 3);
    }
}
