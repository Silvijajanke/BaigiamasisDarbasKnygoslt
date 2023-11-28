using Framework;
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
            string actualResult = Driver.GetPirktiTitle();
            Assert.That(Driver.GetPirktiTitle(), Is.EqualTo("Į krepšelį"));
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
            string actualResult = Driver.GetRedHeart();
            Assert.That(Driver.GetRedHeart(), Is.EqualTo(expectedHeartColor));
            Framework.POM.ProductList.ClickHeart();
        }

    }
}
