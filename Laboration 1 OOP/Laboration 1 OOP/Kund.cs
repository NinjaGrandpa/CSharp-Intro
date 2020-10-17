using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1_OOP
{
    class Kund
    {
        public string kundnamn;
        public List<string> produkter;
        public double totalKostnad;

        public Kund(List<string> totalProdukter, double total)
        {
            produkter = totalProdukter;
            totalKostnad = total;
        }

        public void nyKund()
        {
            Console.Clear();
            Console.WriteLine("Kundnamn:");
            kundnamn = Console.ReadLine();

          
        }
    }
}
