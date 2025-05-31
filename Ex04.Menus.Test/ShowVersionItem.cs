using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionItem : IMenuExecutable
    {
        public void PerformItem()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }
    }
}
