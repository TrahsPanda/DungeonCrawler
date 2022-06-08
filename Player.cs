using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Player
    {
        public string Name { get; set; }
        public byte Defense { get; set; }
        public byte Damage { get; set; }
        public byte Health { get; set; }

        public Player(string name, byte def, byte dmg, byte hlt)
        {
            Name = name;
            Defense = def;
            Damage = dmg;
            Health = hlt;
        }
    }
}
