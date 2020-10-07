using System;

namespace Laboration_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var menyVal = 0;

            Console.WriteLine("Jenslöv AB");
            Console.WriteLine("1) Ny Kund");
            Console.WriteLine("2) Befintliga Order");
            Console.WriteLine("3) Avsluta");

            menyVal = Convert.ToInt32(Console.ReadLine());

            switch (menyVal)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }
        }
    }
}
