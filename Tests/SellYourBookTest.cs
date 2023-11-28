using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class SellYourBookTest : BaseTestWithLogin
    {
        [Test]
        public void SellBook()
        {
            string uzrasas = "Norėdami parduoti knygas užpildykite informaciją, kuri bus naudojama sutarčiai pasirašyti ir finansinėms operacijoms atlikti.";

            Framework.POM.SellYourBook.ClickManoPaskyra();
            Framework.POM.SellYourBook.ClickSkaitytosKnygos();
            Framework.POM.SellYourBook.ClickPradetiPrekyba();
            Framework.POM.SellYourBook.ClickPradeti();
            string actualResult = Driver.GetSellYourBookTitle();
            Assert.That(Driver.GetSellYourBookTitle(), Is.EqualTo(uzrasas));
        }
    }
}
