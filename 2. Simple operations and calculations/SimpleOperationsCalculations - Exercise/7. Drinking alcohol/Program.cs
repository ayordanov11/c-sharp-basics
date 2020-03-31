using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Drinking_alcohol
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 7
            //1. read input - price whiskey, quantity beer, quantity wine, quantity rakia, quantity whiskey
            //2. price rakia = ?, price wine = ?, price beer =?
            //3. total price = total rakia (quantity rakia * price rakia) + total wine + total whiskey + total beer
            //4. print total price

            Console.Write("Whiskey price:");
            double whiskeyPrice = double.Parse(Console.ReadLine());
            Console.Write("Beer liters:");
            double beerLiters = double.Parse(Console.ReadLine());
            Console.Write("Wine liters:");
            double wineLiters = double.Parse(Console.ReadLine());
            Console.Write("Rakia liters:");
            double rakiaLiters = double.Parse(Console.ReadLine());
            Console.Write("Whiskey liters:");
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;

            double totalPrice = (rakiaPrice * rakiaLiters) + (winePrice * wineLiters) + 
                (whiskeyPrice * whiskeyLiters) + (beerPrice * beerLiters);

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
