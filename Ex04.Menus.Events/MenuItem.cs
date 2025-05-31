using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_ItemTitle;
        public bool m_IsRootMenu;
        private readonly List<MenuItem> m_SubItems = new List<MenuItem>();
        public event Action OnMenuItemSelected;
        public MenuItem(string i_ItemTitle, Action i_Action)
        {
            m_ItemTitle = i_ItemTitle;
            OnMenuItemSelected += i_Action;
        }

        public MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
        }

        public string ItemTitle
        {
            get { return m_ItemTitle; }
        }

        public bool IsRoot
        {
            get { return m_IsRootMenu; }
            set { m_IsRootMenu = value; }
        }

        public void AddSubItem(MenuItem i_Item)
        {
            if (i_Item != null)
            {
                m_SubItems.Add(i_Item);
            }
        }

        private void runSubMenuLoop()
        {
            bool isUserPressedExit = false;

            while (!isUserPressedExit)
            {
                Console.Clear();
                Console.WriteLine($"** {ItemTitle} **");
                Console.WriteLine(new string('-', ItemTitle.Length + 6));

                for (int i = 0; i < m_SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {m_SubItems[i].ItemTitle}");
                }

                Console.WriteLine(IsRoot ? "0. Exit" : "0. Back");
                Console.Write("Please enter your choice (0-{0}): ", m_SubItems.Count);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userChoice))
                {
                    if (userChoice == 0)
                    {
                        isUserPressedExit = true;
                        if (m_IsRootMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("Bye!");
                        }
                    }
                    else if (userChoice >= 1 && userChoice <= m_SubItems.Count)
                    {
                        m_SubItems[userChoice - 1].OnChosenItem();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, press Enter to try again...");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number. Press Enter to try again...");
                    Console.ReadLine();
                }
            }
        }

        public void OnChosenItem()
        {
            if (m_SubItems.Count > 0)
            {
                runSubMenuLoop();
            }
            else if (OnMenuItemSelected != null)
            {
                Console.Clear();
                OnMenuItemSelected.Invoke();
                Console.WriteLine();
                Console.WriteLine("Press Enter to return...");
                Console.ReadLine();
            }
        }
    }
}
