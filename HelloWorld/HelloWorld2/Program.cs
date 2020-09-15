using System;

namespace HelloWorld2
{
    class Program
    {

        static int addNumbers(int addAmount)
        {
            var sum = 0;
            var number = 0;

            for (int i = 0; i < addAmount; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum = number + sum;
            }

            return sum;
        }

        static void backwardsMethod(string[] backwardsList)
        {
            var words = "";

            Array.Reverse(backwardsList);

            for (int i = 0; i < backwardsList.Length; i++)
            {
                words = backwardsList[i];
                Console.WriteLine(words);
            }
        }

        static void largeSmall(int[] compareNumbers)
        {
            var small = compareNumbers[0];
            var large = compareNumbers[3];

            for (int i = 0; i < compareNumbers.Length; i++)
            {
                if (compareNumbers[i] < small)
                {
                    small = compareNumbers[i];
                }
            }

            for (int i = 0; i < compareNumbers.Length; i++)
            {
                if (compareNumbers[i] > large)
                {
                    large = compareNumbers[i];
                }
            }

            Console.WriteLine("The smallest number is " + small);
            Console.WriteLine("The largest number is " + large);
        }

        static void Main(string[] args)
        {
            var addAmount = 0;
            string[] wordList = new string[4];
            int[] compareNumbers = new int[4];

            Console.WriteLine("Hello! How many numbers do you want to add up?");
            addAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addNumbers(addAmount));

            Console.WriteLine("Write four words");

            for (int i = 0; i < 4; i++)
            {
                wordList[i] = Console.ReadLine();
            }

            backwardsMethod(wordList);

            Console.WriteLine("Skriv in 4 heltal");

            for (int i = 0; i < 4; i++)
            {
                compareNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            largeSmall(compareNumbers);
        }
    }
}
