using System;

namespace TempCTRL
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 68;
            string cont;

            Console.WriteLine("Welcome to your temperature menu!");
            do
            {
                int desiredTemp = Menu(currentTemp);
                string mode;

                if (currentTemp != desiredTemp)
                {
                    if (currentTemp < desiredTemp)
                    {
                        mode = "Heat";
                    }
                    else
                    {
                        mode = "A/C";
                    }

                    Console.WriteLine($"~~~~{mode} mode activated!~~~~");

                    switch (mode)
                    {
                        case "Heat":
                            currentTemp = Heat(currentTemp, desiredTemp);
                            break;

                        case "A/C":
                            currentTemp = AC(currentTemp, desiredTemp);
                            break;
                    }
                }

                Console.WriteLine("~~~~Cycle is complete!~~~~");

                Console.WriteLine("Do you want to set a new temperature? [1]yes or [2]no");
                cont = Console.ReadLine();

            } while (cont == "1");

            Console.WriteLine("Goodbye! Press Enter to exit.");
        }

        static int Menu(int currentTemp)
        {
            Console.WriteLine($"The temperatrue inside the car is currently: {currentTemp}");
            Console.WriteLine("What is the desired temperature? (Please select a temp 50 - 90)");
            int desiredTemp = int.Parse(Console.ReadLine());

            return desiredTemp;
        }

        static int Heat(int currentTemp, int desiredTemp)
        {
            for (int temp = currentTemp; temp <= desiredTemp; temp++)
            {
                Console.WriteLine("Current Temperature: " + temp);

                currentTemp = temp;

                if (currentTemp == 90)
                {
                    Console.WriteLine("Maximum temperature reached.");
                    break;
                }
            }
            return (currentTemp);
        }
        static int AC(int currentTemp, int desiredTemp)
        {
            for (int temp = currentTemp; temp >= desiredTemp; temp--)
            {
                Console.WriteLine("Current Temperature: " + temp);

                currentTemp = temp;

                if (currentTemp == 50)
                {
                    Console.WriteLine("Minimum temperature reached");
                    break;
                }
            }
            return (currentTemp);
        }
    }
}
