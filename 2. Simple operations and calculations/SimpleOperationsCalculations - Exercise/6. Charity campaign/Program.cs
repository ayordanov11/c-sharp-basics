using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the console
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfSladkari = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfGoffretes= int.Parse(Console.ReadLine());
            int numberOfPanCakes = int.Parse(Console.ReadLine());

            //Prices
            double priceCake = 45;
            double priceGoffrete = 5.80;
            double pricePancake = 3.20;

            //The amount per day from one sladkar
            double resultCake = numberOfCakes * priceCake;
            double resultGoffretes = numberOfGoffretes * priceGoffrete;
            double resultPanCakes = numberOfPanCakes * pricePancake;

            double totalResultForOneDay = (resultCake + resultGoffretes + resultPanCakes) * numberOfSladkari;

            double totalResultForCampaign = totalResultForOneDay * numberOfDays;

            double totalResultAfterExpenses = totalResultForCampaign - ((double)1/8 * totalResultForCampaign);

            //double totalResultAfterExpenses = (totalResultForCampaign / 8) * 7;

            Console.WriteLine($"{totalResultAfterExpenses:F2}");
        }
    }
}
