using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_ProductList
{
    internal class MenuItem
    {
        public MenuItem(string returnString, string text, char menuChar, int priority = 0)
        {
            this.returnString = returnString; // This value will be returned if the item is selected
            this.text = text;
            this.menuChar = menuChar;
            this.priority = priority;
        }

        public string returnString { get; set; }
        public string text { get; set; }
        public char menuChar { get; set; }
        public int priority { get; set; }
    }
}
