using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    // https://soscsrpg.com/build-a-c-wpf-rpg/lesson-05-1-creating-the-game-item-factory/
    internal class ItemGenerator
    {
        public static List<Item> _Items;
        static ItemGenerator()
        {
            _Items = new List<Item>();
            _Items.Add(new Item(0, "Stick", 1, 0, 1, 255));
        }
    }
}
