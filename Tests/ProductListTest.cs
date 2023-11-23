
using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class ProductListTest
    {
        internal class ProductListScenario : BaseTests
        {
            [Test, TestCase(1)]
            public void ProductSearch()
            {
                string ElPastas = "de141488@gmail.com";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
                Framework.POM.Login.EnterElPastoAdresas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickPrisijungti();

                Framework.POM.ProductList.ClickVisosKnygos();
                Framework.POM.ProductList.ClickGrozineLiteratura();
                Framework.POM.ProductList.ClickKlasika();
                Framework.POM.ProductList.ClickBook();
                Framework.POM.ProductList.GetPirktiTitle();
                string actualResult = Driver.GetPirktiTitle();
                Assert.That(Driver.GetPirktiTitle(), Is.EqualTo("Į krepšelį"));

            }
        }
    }
}
