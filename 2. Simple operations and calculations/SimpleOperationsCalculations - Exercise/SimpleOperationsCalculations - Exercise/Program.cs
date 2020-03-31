using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperationsCalculations___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 7 => double 7.00
            //int 12 = > double 12.00
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(number1 * 1.0 / number2);

            //TASK 1
            Console.Write("Dollars: ");
            double dollars = double.Parse(Console.ReadLine());

            double leva = dollars * 1.79549;

            //Console.WriteLine("The amount in bulgarian leva is : " + Math.Round(leva, 2));
            Console.WriteLine($"The amount in bulgarian leva is: {leva:f2}");

            ////TASK 2
            ////1.radians => read
            ////2. degrees = radians * 180 / PI
            ////3. print degrees

            //Console.Write("Type the radians: ");
            //double radians = double.Parse(Console.ReadLine());
            //double degrees = radians * 180 / Math.PI;
            //Console.WriteLine(Math.Round(degrees));
        }
    }
}
