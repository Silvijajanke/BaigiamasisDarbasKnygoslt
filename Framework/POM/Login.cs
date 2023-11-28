namespace Framework.POM
{
    public class Login
    {
        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }

        public static void ClickButtonPrisijungtiRegistruotis()
        {
            Common.ClickElement(Locators.Login.PrisijungtiRegistruotis);
        }

        public static void ClickPrisijungti()
        {
            Common.ClickElement(Locators.Login.Prisijungti);
        }

        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Login.InputElPastoAdresas, ElPastas);
        }

        public static void EnterSlaptazodis(string slaptazodis)
        {
            Common.SendKeysToElement(Locators.Login.InputSlaptazodis, slaptazodis);
        }

        public static void ClickManoPaskyra()
        {
            Common.ClickElement(Locators.Login.ManoPaskyra);
        }
    }
}
