using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Challenges.UI
{
    class MainMenu
    {
        public int MainMenuDisplay()
        {
            Console.WriteLine("Hello, Welcome to the Coding Challenges Main Menu, where you can go back through the coding challenge history and try for yourself!");
            var input = Console.ReadLine();
            Console.WriteLine("From your selection, it seems like you asked for " + input);

            return 1;
        }
    }
}
