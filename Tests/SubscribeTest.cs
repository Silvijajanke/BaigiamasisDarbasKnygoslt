using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class SubscribeTest : BaseTestWithLogin
    {

        [Test]
        public void Subscribe()
        {
            string subscribeTitle = "Naujienlaiškių prenumerata patvirtinta";

            Framework.POM.Subscribe.EnterElPastoAdresas("test@test.com");
            Framework.POM.Subscribe.ClickButtonPrenumeruoti();

            string actualResult = Driver.GetSubscribeTitle();
            Assert.That(Driver.GetSubscribeTitle(), Is.EqualTo(subscribeTitle));
        }
    }
}
