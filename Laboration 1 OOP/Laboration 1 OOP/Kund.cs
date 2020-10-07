using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1_OOP
{
    class Kund
    {
        public string name = "Jenslövs AB";

        public void nyKund()
        {
            Console.Clear();
            Console.WriteLine("Kundnamn:");
            name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Produkter Obs! Skriv in produktnamn och antal av produkt t.ex. 1 12");
            var productChoice = Console.ReadLine();

            String spearator = " ";
            String[] product = productChoice.Split(spearator, 2);

            switch ()
            {
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Kund kund1 = new Kund();
            Console.WriteLine(kund1.name);
        }
    }
}
