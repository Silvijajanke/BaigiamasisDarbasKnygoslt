using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class SellYourBookTest : BaseTestWithLogin
    {
        [Test]
        public void SellBook()
        {
            string expectedMessage = "Norėdami parduoti knygas užpildykite informaciją, kuri bus naudojama sutarčiai pasirašyti ir finansinėms operacijoms atlikti.";

            SellYourBook.ClickManoPaskyra();
            SellYourBook.ClickSkaitytosKnygos();
            SellYourBook.ClickPradetiPrekyba();
            SellYourBook.ClickPradeti();
            string actualMessage = SellYourBook.GetMessage();
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }
    }
}
