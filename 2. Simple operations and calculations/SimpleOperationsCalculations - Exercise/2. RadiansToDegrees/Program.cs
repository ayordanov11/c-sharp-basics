using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 2
            //1.radians => read
            //2. degrees = radians * 180 / PI
            //3. print degrees

            Console.Write("Type the radians: ");
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
