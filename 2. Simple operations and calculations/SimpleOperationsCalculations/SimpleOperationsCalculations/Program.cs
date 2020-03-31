using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperationsCalculations
{
    class Program
    {
        static void Main(string[] args)
        {

            // CTRL + K + C = comment
            // CTRL + K + U = uncomment
            // CTRL + K + D = format code

            // DEMO LIVE

            //int num = int.MaxValue;  //2147483648;
            //double num2 = 5.5;
            //string name = "Plamen";
            //char symbol = ' ';
            //bool check = false;

            //Read from the console //Console.ReadLine always returns string
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            //Registration example
            //Console.Write - it remains on the same row
            //Console.Write("First name:");
            //string firstName = Console.ReadLine();
            //Console.Write("Last name:");
            //string lastName = Console.ReadLine();
            //Console.Write("Email:");
            //string email = Console.ReadLine();
            //Console.Write("Birth year:");
            //int birthYear = int.Parse(Console.ReadLine());
            //Console.Write("Username:");
            //string username = Console.ReadLine();
            //Console.Write("Password:");
            //string password = Console.ReadLine();
            //Console.Write("Money:");
            //double money = double.Parse(Console.ReadLine());

            //string age = "30";
            //int ageAfter7Years = int.Parse(age) + 7;
            //Console.WriteLine(ageAfter7Years);

            //string firstName = "Alex";
            //string lastName = "Yordanov";
            //Console.WriteLine("Hi, " + firstName + " " + lastName);

            //int age = 23;
            //Console.WriteLine("I am " + age + " years old.");

            //5 - 2 = 3 for example
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int result = a - b;
            //Console.WriteLine(result);

            //int a = 5;
            //int b = 7;
            //int product = a * b; // 35

            //one of the data type should be double to see the correct answer
            //double numOfCookies = 5;
            //int numOfPeople = 2;
            //Console.WriteLine(numOfCookies / numOfPeople);

            //We can't divide by 0; //DIVIDE BY ZERO Exception
            //int a = 5;
            //int b = 0;
            //Console.WriteLine(a / b);

            // 25 people
            // 53 cookies
            // 1 lecturer
            // 53 = 25 * 2 + 3
            //int people = 25;
            //int cookies = 53;
            //Console.WriteLine(cookies % people); // The answer is 3, the remainder = остатъка.

            //Console.WriteLine(4 % 2); // 0

            //string firstName = "Alex";
            //string lastName = "Yordanov";
            //string town = "Varna";

            ////I am Alex Yordanov from Varna
            //// interpolation
            //Console.WriteLine($"I am {firstName} {lastName} from {town}");

            //Interpolation another example
            //string firstName = Console.ReadLine();
            //string lastName = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string town = Console.ReadLine();
            //Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

            ////MATH library
            //double num = 5.678954;
            //Console.WriteLine(Math.Round(num, 2)); //6; 6.68 - втори знак след запетаята

            //double num = 5.456; 
            //Console.WriteLine(Math.Ceiling(num)); // -> 6 always up!
            //Console.WriteLine(Math.Floor(num)); // -> 5 always low!

            //Console.WriteLine((Math.PI)); //PI

            //Console.WriteLine(Math.Abs(-50)); // -> 50 always positive in output

            double num = 5.567;
            //Formatting the number
            Console.WriteLine($"num = {num:f2}"); // num = 5.57;
        }
    }
}
