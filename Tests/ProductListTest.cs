using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class ProductListTest : BaseTestWithLogin
    {
        [Test]
        public void ProductSearch()
        {
            string expectedPageTitle = "Nežudyk strazdo giesmininko | Knygos.lt";
            ProductList.ClickVisosKnygos();
            ProductList.ClickGrozineLiteratura();
            ProductList.ClickKlasika();
            ProductList.ClickBook();
            string actualPageTitle = ProductList.GetPageTitle();
            Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle));
        }

        [Test]
        public void QuickProductSearchAndSave()
        {
            string ElPastas = "de141488@gmail.com";
            string slaptazodis = "Demo881414";
            string bookName = "Nežudyk strazdo giesmininko";
            string expectedHeartColor = "#e40f2f";

            Framework.POM.ProductList.EnterBookName(bookName);
            Framework.POM.ProductList.ClickSearch();
            Framework.POM.ProductList.ClickToBook();
            Framework.POM.ProductList.ClickHeart();
            string actualResult = Framework.POM.ProductList.GetPageTitle();
            Assert.That(Framework.POM.ProductList.GetPageTitle(), Is.EqualTo(expectedHeartColor));
            Framework.POM.ProductList.ClickHeart();
        }

    }
}
