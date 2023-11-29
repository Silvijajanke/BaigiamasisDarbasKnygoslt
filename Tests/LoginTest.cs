using NUnit.Framework;
using Framework.POM;

namespace Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            string ElPastas = "de141488@gmail.com";
            string slaptazodis = "Demo881414";

            Login.ClickButtonPrisijungtiRegistruotis();
            Login.EnterElPastoAdresas(ElPastas);
            Login.EnterSlaptazodis(slaptazodis);
            Login.ClickPrisijungti();
            Login.ClickManoPaskyra();
            string actualResult = Login.GetPageTitle();
            Assert.That(actualResult, Is.EqualTo("Asmeniniai duomenys - Knygos.lt"));
        }
    }
}
