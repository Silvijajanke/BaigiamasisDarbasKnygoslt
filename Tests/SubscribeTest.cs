using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class SubscribeTest : BaseTestWithLogin
    {

        [Test]
        public void SubscribeToNewsletter()
        {
            string subscribeTitle = "Naujienlaiškių prenumerata patvirtinta";

            Subscribe.EnterElPastoAdresas("test@test.com");
            Subscribe.ClickButtonPrenumeruoti();

            string actualResult = Subscribe.GetPageTitle();
            Assert.That(Subscribe.GetPageTitle(), Is.EqualTo(subscribeTitle));
        }
    }
}
