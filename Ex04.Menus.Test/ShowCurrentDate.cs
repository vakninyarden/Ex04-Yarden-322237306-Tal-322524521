using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentDate : IMenuExecutable
    {
        public void PerformItem()
        {
            Console.WriteLine($"Current Date is: {DateTime.Now.ToShortDateString()}");
        }
    }
}