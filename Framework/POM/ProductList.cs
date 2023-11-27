

using System;

namespace Framework.POM
{
    public class ProductList
    {
        public static void ClickBook()
        {
            Common.ClickElement(Locators.ProductList.Book);
        }

        public static void ClickGrozineLiteratura()
        {
            Common.ClickElement(Locators.ProductList.GrozineLiteratura);
        }

        public static void ClickHeart()
        {
            Common.ClickElement(Locators.ProductList.HeartIcon);
        }

        public static void ClickIeskokite()
        {
            Common.ClickElement(Locators.ProductList.Search);
        }

        public static void ClickKlasika()
        {
            Common.ClickElement(Locators.ProductList.Klasika);
        }

        public static void ClickSearch()
        {
            Common.ClickElement(Locators.ProductList.Search);
        }

        public static void ClickToBook()
        {
            Common.ClickElement(Locators.ProductList.ToBook);
        }

        public static void ClickVisosKnygos()
        {
            Common.ClickElement(Locators.ProductList.VisosKnygos);
        }

        public static void EnterBookName(string bookName)
        {
            Common.SendKeysToElement(Locators.ProductList.InputBookName, bookName);
        }

        public static string GetPirktiTitle()
        {
            return Common.GetElement(Locators.ProductList.OutputPirktiTitle, "Pirkti");
        }
        public static string GetRedHeart()
        {
            return Common.GetElement(Locators.ProductList.HeartIcon, "color");
        }

    }
}
