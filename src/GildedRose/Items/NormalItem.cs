using System;

namespace GildedRoseKata;

/// <summary>
/// A Normal Item is an item that degrades in quality over time.
/// Once the Selling Period is over (i.e. less than zero) it degrades twice as fast.
/// </summary>
public class NormalItem : Item, IUpdateQuality
{
    public NormalItem(string name, int sellIn, int quality)
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
        var delta = (SellIn < 0) ? 2 : 1;
        Quality -= delta;

        // The quality value can never be less than zero
        Quality = Math.Max(Quality, 0);
    }
}
