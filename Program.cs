using System;


namespace С__18
{
    class Program
    {
        delegate void MenuOption();

        static void Main(string[] args)
        {
            MenuOption[] options = new MenuOption[] { NewGame, LoadGame, ShowRules, ShowAuthor, Exit };
            int input;

            do
            {
                DisplayMenu();
                input = GetInput();

                if (input >= 1 && input <= options.Length)
                {
                    options[input - 1]();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and {0}.", options.Length);
                }

                Console.WriteLine();
            } while (input != options.Length);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Show Rule");
            Console.WriteLine("4 - Show Author");
            Console.WriteLine("5 - Exit");
        }

        static int GetInput()
        {
            Console.Write("Please input a menu option number: ");
            return int.Parse(Console.ReadLine());
        }

        static void NewGame()
        {
            Console.WriteLine("Starting a new game ...");
        }

        static void LoadGame()
        {
            Console.WriteLine("Loading saved game ...");
        }

        static void ShowRules()
        {
            Console.WriteLine("Game rules:");
            Console.WriteLine("- You cannot attack other players until you have gained five experience levels.");
            Console.WriteLine("- You are not allowed to use magic spells if your health level is less than 25%.");
            Console.WriteLine("- You must only buy items from a certain merchant, otherwise you will face a penalty in the form of loss of gold coins.");
        }

        static void ShowAuthor()
        {
            Console.WriteLine("Game author: genius)");
        }

        static void Exit()
        {
            Console.WriteLine("Exit the game...");
        }
    }
}
