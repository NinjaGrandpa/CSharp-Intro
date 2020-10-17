using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboration_1_OOP
{
    class Produkt
    {
        public string namn;
        public double kostnad;

        public Produkt(string produktNamn, double produktKostnad)
        {
            namn = produktNamn;
            kostnad = produktKostnad;
        }

        public void nyOrder()
        {
            List<Produkt> produktlista = new List<Produkt>();
            produktlista.Add(new Produkt("Barkis", 15.95));
            produktlista.Add(new Produkt("Levain", 32.50));
            produktlista.Add(new Produkt("Lingongrova", 30.50));
            produktlista.Add(new Produkt("Rågkaka", 29.50));

            Console.Clear();

            Console.WriteLine("Produklista:");

            var amountProducts = 0;
            foreach (Produkt produkter in produktlista)
            {
                Console.WriteLine("[" + amountProducts + "] " + produkter.namn);
                Console.WriteLine(produkter.kostnad + "kr");
                Console.WriteLine();
                amountProducts++;
            }

            Console.WriteLine("Produkter Obs! Skriv in produktnamn och antal av produkt t.ex. 1 12");

            var fortsätt = true;
            var gånger = 0;
            var produktVal = 0;
            var produktKvantitet = 0;
            var total = 0.00;
            List<string> totalProdukter = new List<string>();
            List<double> totalKostnad = new List<double>();


            while (fortsätt)
            {
                var productChoice = Console.ReadLine();
                String spearator = " ";
                String[] productInput = productChoice.Split(spearator, 2);
                produktVal = Convert.ToInt32(productInput[0]);
                produktKvantitet = Convert.ToInt32(productInput[1]);

                gånger++;
                Console.WriteLine("Vill du lägga till fler produkter?");
                Console.WriteLine("[true/false]");
                fortsätt = Convert.ToBoolean(Console.ReadLine());

                totalProdukter.Add(produktlista[produktVal].namn);
                total = total + produktlista[produktVal].kostnad * produktKvantitet;
            }

            foreach (string abc in totalProdukter)
            {
                Console.WriteLine(abc);
            }

            Console.WriteLine("Total:");
            Console.WriteLine(total + " kr");

            Kund kund1 = new Kund(totalProdukter, total);
            kund1.nyKund();
        }
    }
}
