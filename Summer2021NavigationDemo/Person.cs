using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2021NavigationDemo
{
    public class Person
    {
        public string Name = "Anonymous Player";
        public Area currentArea = new Area();
        public List<Item> Inventory;


        public string ShowInventoryItemNames()
        {
            string output = "";
            foreach (Item i in Inventory)
            {
                output += i.Name + "\n";
            }
            return output;
        }
    }
}
