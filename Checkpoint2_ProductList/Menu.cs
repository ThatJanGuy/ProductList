using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_ProductList
{
    internal class Menu
    {
        public Menu()
        {

        }

        private List<MenuItem> MenuItems = new List<MenuItem>();

        public void AddItem(string returnString, string text, char menuChar, int priority = 0)
        {
            MenuItems.Add(new MenuItem(returnString, text, menuChar, priority));
        }

        public string ShowMenu(char style = 'p', char order = 'a') 
        {
            /* Styles:
             * u: unordered
             * p: ordered by priority
             * t: ordered by text
             * 
             * Order:
             * a: ascending
             * b: descending
             */
            foreach(MenuItem item in MenuItems)
            {
                Console.WriteLine(" > {0} ({1})", item.text, item.menuChar);
            }

            string choice = 
        }
    }
}
