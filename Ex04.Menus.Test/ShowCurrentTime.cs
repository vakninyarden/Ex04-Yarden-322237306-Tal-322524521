using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentTime : IMenuExecutable
    {
        public void PerformItem()
        {
            Console.WriteLine($"Current Time is: {DateTime.Now.ToShortTimeString()}");
        }
    }
}