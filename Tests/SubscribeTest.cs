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

                Framework.POM.Subscribe.EnterElPastoAdresas(ElPastas);
                Framework.POM.Subscribe.ClickSutinkuGautiBendroPobudzioLaiskus();
                Framework.POM.Subscribe.ClickSutinkuGautiPasiulymusIrPaklausimus();
                Framework.POM.Subscribe.ClickButtonPrenumeruoti();

                string actualResult = Driver.GetLoginTitle();
                Assert.That(Driver.GetLoginTitle(), Is.EqualTo("Mano paskyra"));
            }
        }
    }
}
