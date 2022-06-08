using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Debug testing :)\n\n Type item to spawn a random item");
            string input = Console.ReadLine();
            if (input == "item")
            {
                input = "";
                new Item();
            }
        }
    }
}
