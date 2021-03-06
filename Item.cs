using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Item
    {
        public byte TypeID { get; set; }
        public string Name { get; set; }
        public byte Quality { get; set; }
        public byte Defense { get; set; }
        public byte Damage { get; set; }
        public byte Condition { get; set; }

        public Item(byte typeID, string name, byte qlt, byte def, byte dmg, byte cnd)
        {
            TypeID = typeID;
            Name = name;
            Quality = qlt;
            Defense = def;
            Damage = dmg;
            Condition = cnd;
        }
    }
}
