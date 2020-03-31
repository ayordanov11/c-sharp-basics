using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read input -> x1, y1, x2, y2
            //2. length = x1 - x2;
            //3. width = y1 - y2;
            //4. area = length * width
            //5. perimeter = 2 * (length + width)
            //6. print area, perimeter

            double x1 = double.Parse(Console.ReadLine()); //60
            double y1 = double.Parse(Console.ReadLine()); //20
            double x2 = double.Parse(Console.ReadLine()); //10
            double y2 = double.Parse(Console.ReadLine()); //50

            //За да сме сигурно, че и двете страни няма да са отрицателни, за това го правим на двете места.
            double length = Math.Abs(x1 - x2); //50
            double width = Math.Abs(y1 - y2); // 20 - 50 = 30

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
