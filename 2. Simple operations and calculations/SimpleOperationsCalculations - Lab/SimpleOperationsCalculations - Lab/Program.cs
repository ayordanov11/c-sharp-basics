using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperationsCalculations___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine($"Hello {name}");

            // Task 2
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town);
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}");

            //Task 3
            int side = int.Parse(Console.ReadLine());
            int result = side * side;
            //Console.WriteLine("The result is: {0}", result);
            Console.WriteLine("The result is: " + result);

            //Task 4
            //double number = double.Parse(Console.ReadLine());
            //double result = number * 2.54;
            //Console.WriteLine("The result is: " + result);

            //Task 5
            //Console.Write("Your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Number of projects: ");
            //int number = int.Parse(Console.ReadLine());
            //int timeForProject = 3;
            //int result = timeForProject * number;

            //Console.WriteLine("The architect " + name + " will need " + result + " hours to complete " + number + " projects");

            //Task 6
            //Console.Write("Number of dogs is: ");
            //int dogsNumber = int.Parse(Console.ReadLine());
            //Console.Write("Number of other animals: ");
            //int otherAnimals = int.Parse(Console.ReadLine());
            //double dogFood = 2.50;
            //double otherAnimalFood = 4;

            //double priceFoodDogs = dogsNumber * dogFood;
            //double priceFoodOtherAnimals = otherAnimals * otherAnimalFood;
            //double finalResult = priceFoodDogs + priceFoodOtherAnimals;

            //Console.WriteLine("The final result is: " + finalResult);

            //Task 7
            //Console.Write("How many square meters: ");
            //double squareMeters = double.Parse(Console.ReadLine());
            //double wholeGarden = squareMeters * 7.61;
            //double discount = 0.18 * wholeGarden;
            //double result = wholeGarden - discount;

            //Console.WriteLine("The final price is: " + Math.Round(result,2));
            //Console.WriteLine("The discont is: " + Math.Round(discount,2));

            //Task 8
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height; //cm3
            //1dm = 10cm
            //1dm3 = 10 * 10 * 10 cm3

            double totalLiters = volume * 1.0 / 1000;

            // 100 - 17/100*100 = 83;
            // 100 * 0.83

            double liters = totalLiters - (percent / 100) * totalLiters;

            Console.WriteLine($"{liters:f3}");
        }
    }
}
