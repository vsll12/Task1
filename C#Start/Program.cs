using System;

class Program
{
    static void Main(string[] args)
    {
        string menuItem1 = "Option 1";
        string menuItem2 = "Option 2";
        string menuItem3 = "Option 3";
        int selectedIndex = 0;

        void DisplayMenu()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                switch (i)
                {
                    case 0:
                        Console.WriteLine($"-> {menuItem1}");
                        break;
                    case 1:
                        Console.WriteLine($"-> {menuItem2}");
                        break;
                    case 2:
                        Console.WriteLine($"-> {menuItem3}");
                        break;
                }

                Console.ResetColor();
            }
        }

        ConsoleKey keyPressed;
        do
        {
            DisplayMenu();
            keyPressed = Console.ReadKey().Key;

            switch (keyPressed)
            {
                case ConsoleKey.UpArrow:
                    if(selectedIndex == 0)
                    {
                        selectedIndex = 2;
                    }
                    else
                    {
                        selectedIndex -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if(selectedIndex == 2)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        selectedIndex += 1;
                    }
                    break;
            }

        } while (keyPressed != ConsoleKey.Enter);

    }
}
