using Ex04.Menus.Interfaces;
using System;
using static Ex04.Menus.Test.MenuUtils;

namespace Ex04.Menus.Test
{
    public class CountLowercaseLettersItem : IMenuExecutable
    {
        public void PerformItem()
        {
            Console.WriteLine("Please enter a sentence in English only:");
            string userInput = Console.ReadLine();

            while (!IsEnglishOnly(userInput))
            {
                Console.WriteLine("Invalid input. Please enter only English letters and spaces.");
                Console.WriteLine("Please try again:");
                userInput = Console.ReadLine();
            }

            int lowercaseCount = CountLowercaseEnglishLetters(userInput);

            Console.WriteLine($"The number of lowercase English letters is: {lowercaseCount}");
        }
    }
}
