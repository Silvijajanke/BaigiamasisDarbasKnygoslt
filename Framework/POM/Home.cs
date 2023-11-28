namespace Framework.POM
{
    public class Home
    {
        public static void Open()
        {
            Common.OpenPage("https://www.knygos.lt/");
        }

        public static void ClickButtonDeclineCookies()
        {
            Common.WaitForElementToBeVisisble(Locators.Login.ButtonDeclineCookies);
            Common.ClickElement(Locators.Login.ButtonDeclineCookies);
        }

        public static void CloseAdvertising()
        {
            Common.WaitForElementToBeVisisble(Locators.Subscribe.Advertising);
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
    }
}
