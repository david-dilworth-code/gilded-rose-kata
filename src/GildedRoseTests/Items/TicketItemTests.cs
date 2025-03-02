using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class TicketItemTests
    {
       [Theory]
       // All this test data was derived from the "Backstage passes to a TAFKAL80ETC concert" output
       [InlineData(15, 20, 14, 21)]
       [InlineData(14, 21, 13, 22)]
       [InlineData(13, 22, 12, 23)]
       [InlineData(12, 23, 11, 24)]
       [InlineData(11, 24, 10, 25)]
       [InlineData(10, 25, 9, 27)]
       [InlineData(9, 27, 8, 29)]
       [InlineData(8, 29, 7, 31)]
       [InlineData(7, 31, 6, 33)]
       [InlineData(6, 33, 5, 35)]
       [InlineData(5, 35, 4, 38)]
       [InlineData(4, 38, 3, 41)]
       [InlineData(3, 41, 2, 44)]
       [InlineData(2, 44, 1, 47)]
       [InlineData(1, 47, 0, 50)]
       [InlineData(0, 50, -1, 0)]
       [InlineData(-1, 0, -2, 0)]
       [InlineData(10, 49, 9, 50)] // 
        public void WhenUpdateQualityIsCalledThenResultShouldHaveExpectedValues(
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality)
        {
            var item = new TicketItem("Ticket Item", initialSellIn, initialQuality);
            
            item.UpdateQuality();

            Assert.Multiple(
                () => Assert.Equal(expectedSellIn, item.SellIn),
                () => Assert.Equal(expectedQuality, item.Quality)
            );
        }
    }
}

