using GildedRoseProblem.Core;

namespace GildedRoseProblem.Tests
{
    public class GildedRoseTests
    {
        private const string DEFAULT_ITEM = "DEFAULT_ITEM";
        private const int NOT_EXPIRED_SELL_IN = 15;
        private const int DEFAULT_QUALITY = 3;
        private const int EXPIRED_SELL_IN = -1;

        /**
        * Method to test the variation in quality of the actualItem for the non expired
        * Item.
        * 
        * The quality should decrease by 1 when the actualItem is not expired
        * and sell in should decrease by 1.
        * 
        */
        #region NotRefactoredTest

        //[Fact]
        //public void testUpdateQualityDefault1()
        //{
        //    Item item = new Item("DEFAULT_ITEM", 15, 3);
        //    Item[] items = new Item[] { item };
        //    GildedRose app = new GildedRose(items);
        //    app.updateQuality();
        //    Assert.Equal("DEFAULT_ITEM", app.items[0].name);
        //    Assert.Equal(14, app.items[0].sellIn);
        //    Assert.Equal(2, app.items[0].quality);
        //}
        #endregion
        [Fact]
        public void NotExpiredDefaultItem_QualityDecreasesBy1()
        {
            GildedRose app = CreateGildedRoseWithItem(DEFAULT_ITEM, NOT_EXPIRED_SELL_IN, DEFAULT_QUALITY);

            app.UpdateQuality();

            Item expectedItem = new(DEFAULT_ITEM, NOT_EXPIRED_SELL_IN - 1, DEFAULT_QUALITY - 1);
            AssertDefaultItem(expectedItem, app.Items[0]);
        }

        /**
	     * Method to test the variation in quality of the item for the non expired
	     * Item.
	     * 
	     * The quality should decrease by 2 when the item is expired(Sell in  < 0) and sell in should decrease by 1.
	     * 
	     */
        #region UnrefactoredTest2
        //[Fact]
        //public void testUpdateQualityForExpiredItem()
        //{
        //    Item item = new Item("DEFAULT_ITEM", -1, 3);
        //    Item[] items = new Item[] { item };
        //    GildedRose app = new GildedRose(items);
        //    app.updateQuality();
        //    Assert.Equal("DEFAULT_ITEM", app.items[0].name);
        //    Assert.Equal(-2, app.items[0].sellIn);
        //    Assert.Equal(1, app.items[0].quality);
        //}
        #endregion
        [Fact]
        public void ExpiredDefaultItem_QualityDecreasesBy2()
        {
            GildedRose app = CreateGildedRoseWithItem(DEFAULT_ITEM, EXPIRED_SELL_IN, DEFAULT_QUALITY);

            app.UpdateQuality();

            Item expectedItem = new(DEFAULT_ITEM, EXPIRED_SELL_IN - 1, DEFAULT_QUALITY - 2);
            AssertDefaultItem(expectedItem, app.Items[0]);
        }

        private static void AssertDefaultItem(Item expectedItem, Item actualItem)
        {
            Assert.Equal(expectedItem.Name, actualItem.Name);
            Assert.Equal(expectedItem.SellIn, actualItem.SellIn);
            Assert.Equal(expectedItem.Quality, actualItem.Quality);
        }

        private static GildedRose CreateGildedRoseWithItem(string name, int sellIn, int quality)
        {
            Item item = new Item(name, sellIn, quality);
            Item[] items = new Item[] { item };
            GildedRose app = new(items);
            return app;
        }
    }
}