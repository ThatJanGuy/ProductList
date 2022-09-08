using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_ProductList
{
    internal class MenuItem
    {
        public MenuItem(string text, char returnChar, int priority = 0)
        {
            this.text = text;
            this.returnChar = returnChar;
            this.priority = priority;
        }

        public string text { get; set; }
        public char returnChar { get; set; }
        public int priority { get; set; }
    }
}
