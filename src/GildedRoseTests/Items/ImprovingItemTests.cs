using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class ImprovingItemTests
    {
       [Theory]
       // This block of test data was derived from the "Aged Brie" output
       [InlineData(2, 0, 1, 1)]
       [InlineData(1, 1, 0, 2)]
       [InlineData(0, 2, -1, 4)] // Double improvement starts here
       [InlineData(-1, 4, -2, 6)]
       [InlineData(-2, 6, -3, 8)]
       [InlineData(-3, 8, -4, 10)]
       [InlineData(-23, 48, -24, 50)]
       [InlineData(-24, 50, -25, 50)] // Quality is now maxed out at 50
       [InlineData(-25, 50, -26, 50)] 
       [InlineData(-26, 50, -27, 50)] 
       [InlineData(-27, 50, -28, 50)] 
        public void WhenUpdateQualityIsCalledThenResultShouldHaveExpectedValues(
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality)
        {
            var item = new ImprovingItem("Improving Item", initialSellIn, initialQuality);
            
            item.UpdateQuality();

            Assert.Multiple(
                () => Assert.Equal(expectedSellIn, item.SellIn),
                () => Assert.Equal(expectedQuality, item.Quality)
            );
        }
    }
}
