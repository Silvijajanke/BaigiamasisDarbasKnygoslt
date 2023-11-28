namespace Framework.POM
{
    public class SellYourBook
    {
        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }

        public static void ClickManoPaskyra()
        {
            Common.ClickElement(Locators.SellYourBook.ManoPaskyra);
        }

        public static void ClickPradeti()
        {
            Common.ClickElement(Locators.SellYourBook.Pradeti);
        }

        public static void ClickPradetiPrekyba()
        {
            Common.ClickElement(Locators.SellYourBook.PradetiPrekyba);
        }

        public static void ClickSkaitytosKnygos()
        {
            Common.ClickElement(Locators.SellYourBook.SkaitytosKnygos);
        }
    }
}
