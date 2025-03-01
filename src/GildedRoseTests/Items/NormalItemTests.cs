using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class NormalItemTests
    {

       [Theory]
       // This block of test data was derived from the "+5 Dexterity Vest" output
       [InlineData(10, 20, 9, 19)]
       [InlineData(9, 19, 8, 18)]
       [InlineData(8, 18, 7, 17)]
       [InlineData(7, 17, 6, 16)]
       [InlineData(6, 16, 5, 15)]
       [InlineData(5, 15, 4, 14)]
       [InlineData(4, 14, 3, 13)]
       [InlineData(3, 13, 2, 12)]
       [InlineData(2, 12, 1, 11)]
       [InlineData(1, 11, 0, 10)]
       [InlineData(0, 10, -1, 8)] // Degrade by 2 starts here
       [InlineData(-1, 8, -2, 6)]
       [InlineData(-2, 6, -3, 4)]
       [InlineData(-3, 4, -4, 2)]
       [InlineData(-4, 2, -5, 0)]
       [InlineData(-5, 0, -6, 0)] // Quality is now fixed at zero

       // This block of test data was derived from the "Elixir of the Mongoose" output
       [InlineData(5, 7, 4, 6)]
       [InlineData(4, 6, 3, 5)]
       [InlineData(3, 5, 2, 4)]
       [InlineData(2, 4, 1, 3)]
       [InlineData(1, 3, 0, 2)]
       [InlineData(0, 2, -1, 0)] // Degrade by 2 starts here
       [InlineData(-1, 0, -2, 0)] // Quality is now fixed at zero
        public void WhenUpdateQualityIsCalledThenResultShouldHaveExpectedValues(
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality)
        {
            var item = new NormalItem("Normal Item", initialSellIn, initialQuality);
            
            item.UpdateQuality();

            Assert.Multiple(
                () => Assert.Equal(expectedSellIn, item.SellIn),
                () => Assert.Equal(expectedQuality, item.Quality)
            );
        }
    }
}
