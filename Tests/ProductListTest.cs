using NUnit.Framework;

namespace Tests
{
    internal class ProductListTest : BaseTestWithLogin
    {
        [Test]
        public void ProductSearch()
        {
            Framework.POM.ProductList.ClickVisosKnygos();
            Framework.POM.ProductList.ClickGrozineLiteratura();
            Framework.POM.ProductList.ClickKlasika();
            Framework.POM.ProductList.ClickBook();
            string actualResult = Framework.POM.ProductList.GetPageTitle();
            Assert.That(Framework.POM.ProductList.GetPageTitle(), Is.EqualTo("Į krepšelį"));
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
