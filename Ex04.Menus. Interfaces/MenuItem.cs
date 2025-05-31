using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IchosenItem
    {
        void ChosenItem(int i_itemType);
    }

    public class MenuItem
    {
        private string m_ItemTitle;
        private bool m_IsActive = false;
        private int m_ItemType;

        private readonly List<IchosenItem> m_Menus = new List<IchosenItem>();

        public void AttachMenu(IchosenItem i_SicknessObserver)
        {
            m_Menus.Add(i_SicknessObserver);
        }

        public void DetachMenu(IchosenItem i_SicknessObserver)
        {
            m_Menus.Remove(i_SicknessObserver);
        }

        public MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
            //m_IsActive = true;
        }

        public string ItemTitle
        {
            get { return m_ItemTitle; }
            set { m_ItemTitle = value; }
        }

        private void doWhenChosen()
        {
            m_IsActive = true;
            notifyMenues();
        }

        private void notifyMenues()
        {
            foreach (IchosenItem menu in m_Menus)
            {
                menu.ChosenItem(m_ItemType);
            }
        }
    }
}
