using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        public MenuItem m_rootMenu;

        public MainMenu(string io_Title)
        {
            m_rootMenu = new MenuItem(io_Title);
            m_rootMenu.m_IsRootMenu = true;
        }

        public void AddSubItem(MenuItem i_Item)
        {
            if (i_Item != null)
            {
                m_rootMenu.AddSubItem(i_Item);
            }
        }

        public void Show()
        {
            m_rootMenu.OnChosenItem();
        }
    }
}
