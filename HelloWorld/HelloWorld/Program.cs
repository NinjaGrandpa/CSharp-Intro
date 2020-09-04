using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            var myAge = 0;
            var myName = "";
            var mySentience = false;
            var num1 = 0;
            var num2 = 0;
            var num3 = 0;
            var myNumber = "";
            var itsNumber = 0;
            var mathMax = 0;
            var myDay = 0;
            var weekEnd = true;
            

            Console.WriteLine("Enter your name:");
            myName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome " + myName + "!");

            Console.WriteLine("Enter your age:");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(myName + ". Am I sentient?");
            Console.WriteLine("Write (true) or (false)");
            mySentience = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
            
            if(!mySentience)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good.");
                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Enter three numbers");
                Console.WriteLine("First number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Third number");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Which is your favourite number? " + num1 + ", " + num2 + " or " + num3 + "?");
                myNumber = Console.ReadLine();

                mathMax = Math.Max(num1, num2);
                itsNumber = Math.Max(mathMax, num3);


                if(myNumber == Convert.ToString(itsNumber))
                {
                    Console.Clear();
                    Console.WriteLine("You chose " + myNumber + "! Very good, my number was also " + itsNumber);
                    Console.ReadLine();

                    

                    while (weekEnd)
                    {
                        Console.Clear();
                        Console.WriteLine(myName + ", What is your favourite weekend? Write the number of the day.");
                        Console.WriteLine("1) Saturday");
                        Console.WriteLine("2) Sunday");
                        Console.WriteLine("3) ¤¤¤¤¤¤");

                        myDay = Convert.ToInt32(Console.ReadLine());
                        switch (myDay)
                        {
                            case 1:
                                weekEnd = false;
                                break;

                            case 2:
                                weekEnd = false;
                                break;

                            defaults
                                Console.WriteLine("¤");
                                break;
                        }
                    }
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
                

                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("F   E   A   R    M  E.");
                }
            }
            
        }
    }
}
