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
            string bookName = "Nežudyk strazdo giesmininko";

            ProductList.EnterBookName(bookName);
            ProductList.ClickSearch();
            ProductList.ClickToBook();
            ProductList.ClickHeart();
            Assert.That(ProductList.IsHeartClicked(true), Is.EqualTo(true));
            ProductList.ClickHeart();
            Assert.That(ProductList.IsHeartClicked(false), Is.EqualTo(false));
        }
    }
}
