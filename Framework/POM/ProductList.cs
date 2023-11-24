

using System;

namespace Framework.POM
{
    public class ProductList
    {
        public static void ClickBook()
        {
            Common.ClickElement(Locators.ProductList.ClickBook);
        }

        public static void ClickGrozineLiteratura()
        {
            Common.ClickElement(Locators.ProductList.ClickGrozineLiteratura);
        }

        public static void ClickHeart()
        {
            Common.ClickElement(Locators.ProductList.ClickHeart);
        }

        public static void ClickIeskokite()
        {
            Common.ClickElement(Locators.ProductList.ClickIeskokite);
        }

        public static void ClickKlasika()
        {
            Common.ClickElement(Locators.ProductList.ClickKlasika);
        }

        public static void ClickSearch()
        {
            Common.ClickElement(Locators.ProductList.ClickSearch);
        }

        public static void ClickToBook()
        {
            Common.ClickElement(Locators.ProductList.ClickToBook);
        }

        public static void ClickVisosKnygos()
        {
            Common.ClickElement(Locators.ProductList.ClickVisosKnygos);
        }

        public static void EnterBookName(string bookName)
        {
            Common.SendKeysToElement(Locators.ProductList.EnterBookName, bookName);
        }

        public static string GetPirktiTitle()
        {
            return Common.GetElement(Locators.ProductList.GetPirktiTitle);
        }
        public static void GetRedHeart()
        {
            return Common.GetElement(Locators.ProductList.GetRedHeart);
        }
    }
}
