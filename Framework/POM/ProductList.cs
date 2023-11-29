namespace Framework.POM
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
            Common.WaitForElementToBeVisisble(Locators.ProductList.HeartIcon);
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

        public static bool IsHeartClicked(bool expectClicked)
        {
            if (expectClicked)
            {
                Common.WaitForElementHtmlAttributeToContainValue(Locators.ProductList.HeartIcon, "class", "active");
            } else
            {
                Common.WaitForElementHtmlAttributeToNotContainValue(Locators.ProductList.HeartIcon, "class", "active");
            }

            return Common.ElementHtmlAttributeContainsValue(Locators.ProductList.HeartIcon, "class", "active");
        }
    }
}
