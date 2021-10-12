


using System;

namespace hello_world
{
	class Program
	{
		static void Main(string[] args)
        {
            ChangeColormessege(ConsoleColor.Green, "hello wanna play a game enter you name");

            Console.ForegroundColor = ConsoleColor.Cyan;

			string inputName = Console.ReadLine();

            Console.ResetColor();

            while (true)
            {
                ChangeColormessege(ConsoleColor.Green, $"ok {inputName} guess a number 1-10");

                Random random = new Random();

                int currectNumber = random.Next(1, 10);

                int guees = 0;

                while (guees != currectNumber)
                {
                    string inputNumber = Console.ReadLine();

                    if (!int.TryParse(inputNumber, out guees))
                    {
                        ChangeColormessege(ConsoleColor.DarkRed, "pls wright a number");
                        continue;
                    }

                    guees = Int32.Parse(inputNumber);

                    if (guees != currectNumber)
                    {
                        ChangeColormessege(ConsoleColor.DarkRed, "wrong number try again");
                    }

                }

                ChangeColormessege(ConsoleColor.Yellow, "CORRECT!");

                Console.WriteLine("play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }


                Console.ReadKey();
            }
        }

        static void ChangeColormessege(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
	}
}
