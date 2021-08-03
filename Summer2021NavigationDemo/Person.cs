using System.Collections.Generic;
using System.Windows.Media;

namespace Summer2021NavigationDemo
{
    public class Person
    {
        public string Name = "Anonymous Player";
        public Area currentArea = new Area();
        public List<Item> Inventory;
        public SolidColorBrush Status = new SolidColorBrush(Colors.Orchid);
        public Robot Friend = new Robot();
        public InfinityStone Stone = new InfinityStone();

        public string ShowInventoryItemNames()
        {
            string output = "";
            foreach (Item i in Inventory)
            {
                output += i.Name + "\n";
            }
            return output;
        }

        public Item SearchInventory(string term) => Inventory.Find(x => x.Name.Contains(term));

        public Person()
        {
            Stone.Color = StoneColor.Blue;

            if (Stone.Color == StoneColor.Purple)
            {

            }
        }
    }
}
