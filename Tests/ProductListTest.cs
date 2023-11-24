
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
                string actualResult = Driver.GetPirktiTitle();
                Assert.That(Driver.GetPirktiTitle(), Is.EqualTo("Į krepšelį"));

            }
            [Test, TestCase(2)]
            public void QuickProductSearchAndSave()
            {
                string ElPastas = "de141488@gmail.com";
                string slaptazodis = "Demo881414";
                string bookName = "Nežudyk strazdo giesmininko";

                Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
                Framework.POM.Login.EnterElPastoAdresas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickPrisijungti();

                //Framework.POM.ProductList.ClickIeskokite();
                Framework.POM.ProductList.EnterBookName(bookName);
                Framework.POM.ProductList.ClickSearch();
                Framework.POM.ProductList.ClickToBook();
                Framework.POM.ProductList.ClickHeart();
                string actualResult = Driver.GetRedHeart();
                Assert.That(Driver.GetRedHeart(), Is.EqualTo(""));

            }
        }
    }
}
