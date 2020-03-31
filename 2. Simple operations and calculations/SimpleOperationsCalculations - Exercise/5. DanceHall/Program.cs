using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 5
            //1. Read length, width, side wardrobe (m)
            //2. Area of Hall = length * width
            //3. area wardrobe = side wardrobe * side wardrobe
            //4. area bench = area of hall / 10
            //5. free space = area of hall - wardrobe - area bench
            //6. dancers = free space / 7040
            //7. print dancers -> Math.Floor

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            //we want it in CM, so m * 100 = CM
            double areaHall = (length * 100) * (width * 100);
            //again we need to transform from meters to centimeters
            double areaWardrobe = (wardrobeSide * 100) + (wardrobeSide * 100);

            double areaBench = areaHall / 10;

            double freeSpace = areaHall - areaWardrobe - areaBench;

            //Number of dancers
            double dancers = freeSpace / 7040;

            //Math.Floor - защото закръгляме до най-близкото цяло число.
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
