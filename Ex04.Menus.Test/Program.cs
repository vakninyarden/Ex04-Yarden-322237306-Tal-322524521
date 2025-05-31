using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runMenuInterfaceImplementation();
        }

        private static void runMenuInterfaceImplementation()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Delegates Main Menu");
            Interfaces.MenuItem lettersAndVersion = new Interfaces.MenuItem("Letters and Version");
            Interfaces.MenuItem dateAndTime = new Interfaces.MenuItem("Show Current Date/Time");

            lettersAndVersion.AddSubItem(new Interfaces.MenuItem("Show Version") { MenuAction = new ShowVersionItem() });
            lettersAndVersion.AddSubItem(new Interfaces.MenuItem("Count Lowercase Letters") { MenuAction = new CountLowercaseLettersItem() });
            dateAndTime.AddSubItem(new Interfaces.MenuItem("Show Current Date") { MenuAction = new ShowCurrentDate() });
            dateAndTime.AddSubItem(new Interfaces.MenuItem("Show Current Time") { MenuAction = new ShowCurrentTime() });
            mainMenu.AddSubItem(lettersAndVersion);
            mainMenu.AddSubItem(dateAndTime);
            mainMenu.Show();
        }

        private static void runMenuEventsImplementation()
        {
            /*Events.MainMenu mainMenu = new Events.MainMenu("Delegates Main Menu");
            Events.MenuItem lettersAndVersion = new Events.MenuItem("Letters and Version");
            Events.MenuItem dateAndTime = new Events.MenuItem("Show Current Date/Time");

            lettersAndVersion.AddSubItem(new Events.MenuItem("Show Version", ShowVersion.Show));
            lettersAndVersion.AddSubItem(new Events.MenuItem("Count Lowercase Letters", CountLowercase.Count));
            dateAndTime.AddSubItem(new Events.MenuItem("Show Current Date", ShowDate.Show));
            dateAndTime.AddSubItem(new Events.MenuItem("Show Current Time", ShowTime.Show));
            mainMenu.AddItem(lettersAndVersion);
            mainMenu.AddItem(dateAndTime);
            mainMenu.Show();*/
        }
    }
}
