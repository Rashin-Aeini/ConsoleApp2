using System;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator!");


            bool keepLooping = true;

            while (keepLooping)
            {

                Console.WriteLine("---- Menu ----"
                                  + "\n1. Add"
                                  + "\n2. Minus"
                                  + "\n3. Multiply"
                                  + "\n4. Divided"
                                  + "\n9. Exit\n"
                                  );

                int selection = AskUserForNumber();

                switch (selection)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Minus();
                        break;

                    case 3:
                        Multiply();
                        break;

                    case 4:
                        Divided();
                        break;

                    case 9:
                        keepLooping = false;
                        Console.WriteLine("Thanks for touring this program.");
                        break;

                    default:
                        Console.WriteLine("Incorrect selection!");
                        break;
                }
                PressToContinue();
            }


        }
        static void Add()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}+ {1}={2}", a, b, a + b);
        }

        static void Minus()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        }

        static void Multiply()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        }

        static void Divided()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            if(b!=0)
            {
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            }
            
        }

        static int AskUserForNumber()
        {
            bool wasNotNumber = true;
            int number = 0;

            do
            {
                Console.WriteLine("Please enter your selection :");
                string input = Console.ReadLine();
                wasNotNumber = !int.TryParse(input, out number);

            } while (wasNotNumber);

            return number;
        }

        static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }


    }

}




