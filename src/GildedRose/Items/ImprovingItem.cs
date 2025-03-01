using System;

namespace GildedRoseKata;

/// <summary>
/// An Improving Item is an item that improves in quality over time.
/// The Quality value will increase by 1 during the Selling Period. 
/// Once the Selling Period is over the Quality will increase by 2.
/// </summary>
public class ImprovingItem : Item, IUpdateQuality
{
    public ImprovingItem(string name, int sellIn, int quality)
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
        Quality += delta;

        // The quality value can never be more than the maximum
        Quality = Math.Min(Quality, 50);
    }
}