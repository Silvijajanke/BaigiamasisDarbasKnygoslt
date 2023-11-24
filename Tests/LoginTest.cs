using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class LoginTest
    {
        internal class LoginScenario : BaseTests
        {
            [Test]
            public void Login()
            {
                string ElPastas = "de141488@gmail.com";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
                Framework.POM.Login.EnterElPastoAdresas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickPrisijungti();
                string actualResult = Driver.GetLoginTitle();
                Assert.That(Driver.GetLoginTitle(), Is.EqualTo("Mano paskyra"));
            }
        }
    }
}
