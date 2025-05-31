using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu menu1 = new Interfaces.MainMenu();
            menu1.m_Items[0].ItemTitle = "1";
        }
    }
}
