
namespace Framework.POM
{
    public class Login
    {
        public static void ClickButtonDeclineCookies()
        {
            Common.ClickElement(Locators.Login.ClickButtonDeclineCookies);
        }
        public static void ClickButtonPrisijungtiRegistruotis()
        {
            Common.ClickElement(Locators.Login.ClickButtonPrisijungtiRegistruotis);
        }

        public static void ClickPrisijungti()
        {
            Common.ClickElement(Locators.Login.ClickPrisijungti);
        }

        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Login.EnterElPastoAdresas, ElPastas);
        }

        public static void EnterSlaptazodis(string slaptazodis)
        {
            Common.SendKeysToElement(Locators.Login.EnterSlaptazodis, slaptazodis);
        }

        public static void Open()
        {
            Driver.OpenPage("https://www.knygos.lt/");
        }
        public static string GetLoginTitle()
        {
            return Common.GetElementText(Locators.Login.GetLoginTitle);
        }
    }
}
