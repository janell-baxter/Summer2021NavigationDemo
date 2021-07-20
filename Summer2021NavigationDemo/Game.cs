using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2021NavigationDemo
{
    public class Game
    {
        //One class can contain instances of another class
        //This is called Containment - the relationship is informally 
        //known as "has a"

        public string Name = "Super Awesome Game";
        //A Game has multiple Areas
        public List<Area> Areas = new List<Area>();
        //Game has a Player
        public Person Player = new Person();

        //other 2 important relationships
        //"is a" - inheritance
        //"uses a" - general association

    }
}
