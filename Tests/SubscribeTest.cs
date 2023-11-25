using Framework;
using NUnit.Framework;
using static Tests.BaseTests;

namespace Tests
{
    internal class SubscribeTest
    {
        internal class SubscribeScenario : BaseTest
        {

            [Test]
            public void Subscribe()
            {
                string ElPastas = "de141488@gmail.com";
                string slaptazodis = "Demo881414";
                string subscribeTitle = "Naujienlaiškių prenumerata patvirtinta";

                Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
                Framework.POM.Login.EnterElPastoAdresas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickPrisijungti();
                
                Framework.POM.Subscribe.EnterElPastoAdresas(ElPastas);
                Framework.POM.Subscribe.ClickSutinkuGautiBendroPobudzioLaiskus();
                Framework.POM.Subscribe.ClickSutinkuGautiPasiulymusIrPaklausimus();
                Framework.POM.Subscribe.ClickButtonPrenumeruoti();

                string actualResult = Driver.GetSubscribeTitle();
                Assert.That(Driver.GetSubscribeTitle(), Is.EqualTo(subscribeTitle));
            }
        }
    }
}
