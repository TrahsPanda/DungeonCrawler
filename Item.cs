using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Item
    {
        internal static byte next = 0;
        public byte id = next++;
        public string name;
        public byte quality;
        public byte defense;
        public byte damage;
        public byte condition;

        public Item()
        {
            id = 0;
            name = "debug";
            quality = 0;
            defense = 0;
            damage = 0;
            condition = 0;
        }
    }
}
