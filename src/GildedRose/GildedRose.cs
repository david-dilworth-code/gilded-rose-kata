using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                // Handle items that can just update themself (Tell Don't Ask!)
                if (Items[i] is IUpdateQuality)
                {
                    var item = Items[i] as IUpdateQuality;
                    item.UpdateQuality();
                }
            }
        }
    }
}
