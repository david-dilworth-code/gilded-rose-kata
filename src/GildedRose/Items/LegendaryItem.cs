namespace GildedRoseKata;

/// <summary>
/// A Legendary Item is an item that does not need to be sold and has a fixed quality score of 80.
/// </summary>
public sealed class LegendaryItem : Item, IUpdateQuality
{
    public LegendaryItem(string name, int sellIn)
    {
        Name = name;
        SellIn = sellIn;
        Quality = 80;
    }

    public void UpdateQuality()
    {
        // There is nothing to do here, because Legendary Items never change
        return;
    }
}
