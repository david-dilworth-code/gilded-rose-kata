using System;

namespace GildedRoseKata;

/// <summary>
/// A Ticket Item is an item that improves in quality during the Selling Period and then has zero value afterwards.
/// </summary>
public class TicketItem : Item, IUpdateQuality
{
    public TicketItem(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        // The first thing that changes is the date
        SellIn -= 1;

        // If the Selling Period is finished this item has no value
        if (SellIn < 0)
        {
            Quality = 0;
        }
        else if (SellIn < 5)
        {
            Quality += 3;
        }
        else if (SellIn < 10)
        {
            Quality += 2;
        }
        else
        {   
            Quality += 1;
        }

        // The quality value can never be more than the maximum
        Quality = Math.Min(Quality, 50);
    }
}
