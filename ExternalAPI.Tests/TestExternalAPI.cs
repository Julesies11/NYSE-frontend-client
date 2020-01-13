using System.Threading.Tasks;
using NUnit.Framework;
using ExternalAPI;

namespace ExternalAPI.Tests
{
    // test the external API for GET methods only

    [TestFixture]
    public class TestExternalAPI
    {
        [Test]
        public async Task GetUser_IsInstanceOf()
        {
            // test the return type is 'User'
            var sut = await Api.GetUser();

            Assert.IsInstanceOf<User>(sut);

        }

        [Test]
        public async Task GetUser_EqualTo()
        {
            // test the return value of Id = 1
            var sut = await Api.GetUser();

            int shouldEqual = 1;
            Assert.That(sut.id, Is.EqualTo(shouldEqual));

        }

    }
}
