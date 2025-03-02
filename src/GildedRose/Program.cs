using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new NormalItem("+5 Dexterity Vest", 10, 20),
                new ImprovingItem("Aged Brie", 2, 0),
                new NormalItem("Elixir of the Mongoose", 5, 7),
                new LegendaryItem("Sulfuras, Hand of Ragnaros", 0),
                new LegendaryItem("Sulfuras, Hand of Ragnaros", -1),
                new TicketItem
                (
                    "Backstage passes to a TAFKAL80ETC concert",
                    15,
                    20
                ),
                new TicketItem
                (
                    "Backstage passes to a TAFKAL80ETC concert",
                    10,
                    49
                ),
                new TicketItem
                (
                    "Backstage passes to a TAFKAL80ETC concert",
                    5,
                    49
                ),
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
