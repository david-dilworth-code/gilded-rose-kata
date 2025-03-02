using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredItemTests
    {
        [Theory]
        // Behaviour during Selling Period (degrades at normal rate)
        [InlineData(1, 50, 0, 48)]
        [InlineData(1, 5, 0, 3)]
        [InlineData(1, 4, 0, 2)]
        [InlineData(1, 3, 0, 1)]
        [InlineData(1, 2, 0, 0)]
        [InlineData(1, 1, 0, 0)]
        [InlineData(1, 0, 0, 0)]

        // Behaviour after Selling Period has finished (degrades twice as fast)
        [InlineData(0, 50, -1, 46)]
        [InlineData(0, 5, -1, 1)]
        [InlineData(0, 4, -1, 0)]
        [InlineData(0, 3, -1, 0)]
        [InlineData(0, 2, -1, 0)]
        [InlineData(0, 1, -1, 0)]
        [InlineData(0, 0, -1, 0)]
        public void WhenUpdateQualityIsCalledThenResultShouldHaveExpectedValues(
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality)
        {
            var item = new ConjuredItem("Conjured Item", initialSellIn, initialQuality);
            
            item.UpdateQuality();

            Assert.Multiple(
                () => Assert.Equal(expectedSellIn, item.SellIn),
                () => Assert.Equal(expectedQuality, item.Quality)
            );
        }
    }
}