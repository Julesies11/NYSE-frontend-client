using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAPI.Tests
{
    class TestModel
    {
        // test the User class attributes for validation errors such as null values
        [Test]
        public void VerifyClassAttributes()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            // create the test object
            User u = new User();
            u.userId = 1;
            u.id = 2;
            u.title = "TEST";
            u.completed = true;

            // test there arent any validation errors
            var errorcount = cpv.testValidation(u).Count();
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
