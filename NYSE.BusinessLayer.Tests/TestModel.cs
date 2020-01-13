using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NYSE.BusinessLayer;
using System.ComponentModel.DataAnnotations;

namespace NYSE.BusinessLayer.Tests
{
    class TestModel
    {
        // test the DailyPrice class attributes for validation errors such as null values
        [Test]
        public void VerifyClassAttributes()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            // create the test object
            DailyPrice dailyPrice = new DailyPrice();
            dailyPrice.date = new DateTime(2019, 1, 1);
            dailyPrice.stock_symbol = "TEST";
            dailyPrice.stock_price_open = 50;
            dailyPrice.stock_price_close = 100;
            dailyPrice.stock_price_low = 10;
            dailyPrice.stock_price_high = 100;
            dailyPrice.stock_price_adj_close = 100;
            dailyPrice.stock_volume = 1000;
            dailyPrice.stock_exchange = "NYSE";

            // test there arent any validation errors
            var errorcount = cpv.testValidation(dailyPrice).Count();
            Assert.AreEqual(0, errorcount);

        }

    }

    // helper class to check properties of a model class
    public class CheckPropertyValidation
    {
        public IList<ValidationResult> testValidation(object model)
        {
            var result = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);
            Validator.TryValidateObject(model, validationContext, result);
            if (model is IValidatableObject) (model as IValidatableObject).Validate(validationContext);
            return result;
        }

    }



}
