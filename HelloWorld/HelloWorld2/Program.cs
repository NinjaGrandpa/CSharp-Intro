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

        static string[] backwardsList(string[] backwardsList)
        {
            string[] backwards = new string[4];

            Array.Reverse(backwardsList);

            for (int i = 0; i < backwardsList.Length; i++)
            {
                backwards[i] = backwardsList[i];
            }

            return backwards;
        }

        static void Main(string[] args)
        {
            var addAmount = 0;
            string[] wordList = new string[4];

            Console.WriteLine("Hello! How many numbers do you want to add up?");
            addAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addNumbers(addAmount));

            Console.WriteLine("Write four words");
            for (int i = 0; i < wordList.Length; i++)
            {
                wordList[i] = Console.ReadLine();
            }

            Console.WriteLine(backwardsList(wordList));




        }
    }
}
