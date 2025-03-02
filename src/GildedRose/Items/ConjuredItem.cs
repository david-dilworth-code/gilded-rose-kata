using System;

namespace GildedRoseKata;

/// <summary>
/// A Conjured Item is an item that degrades in Quality twice as fast as a Normal Item.
/// </summary>
public class ConjuredItem : Item, IUpdateQuality
{
    public ConjuredItem(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        // The first thing that changes is the date
        SellIn -= 1;

        // Calculate the delta required to recalculate the Quality based on where the item is in its Selling Period
        var delta = (SellIn < 0) ? 4 : 2;
        Quality -= delta;

        // The quality value can never be less than zero
        Quality = Math.Max(Quality, 0);
    }
}

