using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using NYSE.BusinessLayer;

namespace NYSE.BusinessLayer.Tests
{
    // test the API for GET methods only

    [TestFixture]
    public class TestAPI
    {
        [Test]
        public async Task HelloWorld_EqualTo()
        {
            string sut = await Api.HelloWorld();
            string shouldEqual = "Hello World";
            Assert.That(sut, Is.EqualTo(shouldEqual));
        }

        [Test]
        public async Task GetDailyPrices_IsInstanceOf()
        {
            // test the return of type IEnumerable 'DailyPrice'
            var sut = await Api.GetDailyPrices(100);

            Assert.IsInstanceOf<IEnumerable<DailyPrice>>(sut);

        }

        [Test]
        public async Task GetDailyPrice_IsInstanceOf()
        {
            // test the return value if of type 'DailyPrice'
            var sut = await Api.GetDailyPrice(100);

            Assert.IsInstanceOf<DailyPrice>(sut);

        }

        [Test]
        public async Task GetDailyPrice_EqualTo()
        {
            // check the stock symbol of Id 100 = 'AEG'
            var sut = await Api.GetDailyPrice(100);

            string shouldEqual = "AEG";
            Assert.That(sut.stock_symbol, Is.EqualTo(shouldEqual));

        }

        /*
        TEST POST AND DELETE. NOTE: this will modify records in the database. Only run against DEV database
        [Test]
        public async Task PostDailyPrice_IsInstanceOf()
        {
            // test the return type is 'DailyPrice'

            // first delete any test prices in the database
            //var deleteSymbol = await Api.DeleteDailyPrices("TEST");

            // create the test object
            DailyPrice dailyPrice = new DailyPrice();
            dailyPrice.date = new DateTime(2019,1,1);
            dailyPrice.stock_symbol = "TEST";
            dailyPrice.stock_price_open = 50;
            dailyPrice.stock_price_close = 100;
            dailyPrice.stock_price_low = 10;
            dailyPrice.stock_price_high = 100;
            dailyPrice.stock_price_adj_close = 100;
            dailyPrice.stock_volume = 1000;
            dailyPrice.stock_exchange = "NYSE";

            // check the post works correctly
            var sut = await Api.PostDailyPrice(dailyPrice);

            // delete the created value
            int id = sut.Id;
            //var delete = await Api.DeleteDailyPrice(id);

            // check the return value if of type 'DailyPrice'
            Assert.IsInstanceOf<DailyPrice>(sut);

        }

        [Test]
        public async Task DeleteDailyPrice_IsInstanceOf()
        {
            // test the return type is 'DailyPrice'

            // check the delete works correctly
            var sut = await Api.DeleteDailyPrice(102705);

            // check the return value if of type 'DailyPrice'
            Assert.IsInstanceOf<DailyPrice>(sut);

        }
        */

    }
}
