using System;

namespace ConsoleApp2
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
                                  + "\n1. add"
                                  + "\n2. minus"
                                  + "\n3. multiply"
                                  + "\n4. divided"
                                  + "\n9. Exit\n"
                                  );

                int selection = AskUserForNumber();

                switch (selection)
                {
                    case 1:
                        add();
                        break;

                    case 2:
                        minus();
                        break;

                    case 3:
                        multiply();
                        break;

                    case 4:
                        divided();
                        break;

                    case 9:
                        keepLooping = false;
                        Console.WriteLine("Thanks for youring this program.");
                        break;

                    default:
                        Console.WriteLine("Incorrect selection!");
                        break;
                }
                PressToContinue();
            }


        }
        static void add()
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

        static void minus()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}+ {1}={2}", a, b, a - b);
        }

        static void multiply()
        {
            float a, b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            b = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}+ {1}={2}", a, b, a * b);
        }

        static void divided()
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
                Console.WriteLine("{0}+ {1}={2}", a, b, a / b);
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




