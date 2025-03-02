using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void ItemNameIsUnchangedAfterUpdate()
        {
            const string expectedName = "foo";

            IList<Item> Items = new List<Item> { new NormalItem(expectedName, 0, 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedName, Items[0].Name);
        }
    }
}
