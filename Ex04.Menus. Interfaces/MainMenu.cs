using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IchosenItem
    {
        public readonly List<MenuItem> m_Items = new List<MenuItem>();

        public MainMenu()
        {

            MenuItem itemType0 = new MenuItem("0");
            itemType0.AttachMenu(this as IchosenItem);
            m_Items.Add(itemType0);

            MenuItem itemType1 = new MenuItem("1");
            itemType1.AttachMenu(this as IchosenItem);
            m_Items.Add(itemType1);

            MenuItem itemType2 = new MenuItem("2");
            itemType2.AttachMenu(this as IchosenItem);
            m_Items.Add(itemType2);
        }

        public void ChosenItem(int i_itemType)
        {
            Console.WriteLine("You have chosen item type: " + i_itemType);
        }
    }
}
