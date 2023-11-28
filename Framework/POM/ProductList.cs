﻿namespace Framework.POM
{
    public class ProductList
    {
        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }

        public static void ClickBook()
        {
            Common.WaitForElementToBeVisisble(Locators.ProductList.Book);
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
    }
}
