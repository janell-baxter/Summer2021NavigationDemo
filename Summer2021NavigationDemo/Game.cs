using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

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
        public Person Player = new Person
        {
            Inventory = new List<Item> 
            {
                new Item
                {
                    Name = "Pebble",
                    Description = "Appears to be an ordinary pebble.",
                    Value = 8.5
                }, 
                new Charm
                {
                    Name = "Karma Charma",
                    Description = "Will this improve your karma? Outlook uncertain.",
                    Value = 900
                }
            }
        };

        //other 2 important relationships
        //"is a" - inheritance
        //"uses a" - general association

        public Game()
        {
            Areas.Add(
                new Area 
                {
                    Name = "Desert of Sand",
                    Description="A big desert full of sand. Beautiful and sandy.",
                    Image = new BitmapImage(new Uri("media/Desert.bmp", UriKind.Relative))
                }
                );

            Areas.Add(
                new Area
                {
                    Name = "Mountain of Tallness",
                    Description = "A tall mountain. Like... really tall."
                }
                );

            Areas.Add(
                new Area
                {
                    Name = "Sea of Seawater",
                    Description = "It is a big sea full of ... you got it... seawater."
                }
                );
        }

    }
}
