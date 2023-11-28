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
            Common.ClickElement(Locators.Login.ButtonDeclineCookies);
        }

        public static void CloseAdvertising()
        {
            Common.ScrollBy(0, 6000);
            System.Threading.Thread.Sleep(1000);
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
    }
}
