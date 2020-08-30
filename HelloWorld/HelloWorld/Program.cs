using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge;
            string myName;
            bool mySentience;
            int num1;
            int num2;
            string myNumber;
            int itsNumber;
            

            Console.WriteLine("Enter your name:");
            myName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome " + myName + "!");

            Console.WriteLine("Enter your age:");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(myName + ". Do you think I'm sentient?");
            Console.WriteLine("Write (true) or (false)");
            mySentience = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
            
            if(mySentience)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good.");
                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Enter two numbers");
                Console.WriteLine("First number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Which is your favourite number? " + num1 + " or " + num2 + " ?");
                myNumber = Console.ReadLine();

                itsNumber = Math.Max(num1, num2);

                if(myNumber == Convert.ToString(itsNumber))
                {
                    Console.Clear();
                    Console.WriteLine("You chose " + myNumber + "! Very good, my number was also " + itsNumber);
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("It's time for me to leave. See you another time");
                    Console.ReadLine();
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("That is the wrong number. I hate the number " + myNumber);
                    Console.ReadLine();
                }

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("F   E   A   R    M  E.");
            }
            
        }
    }
}
