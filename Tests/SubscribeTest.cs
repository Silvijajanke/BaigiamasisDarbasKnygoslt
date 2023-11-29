using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class SubscribeTest : BaseTestWithLogin
    {

        [Test]
        public void SubscribeToNewsletter()
        {
            string expectedResult = "Beveik baigta...";

            Subscribe.EnterElPastoAdresas("vartotojas@gmail.com");
            Subscribe.ClickButtonPrenumeruoti();
            string actualResult = Subscribe.GetHeading();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
