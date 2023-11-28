namespace Framework.POM
{
    public class Subscribe
    {
        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }

        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Subscribe.InputElPastoAdresas, ElPastas);
        }
        
        public static void ClickButtonPrenumeruoti()
        {
            Common.ClickElement(Locators.Subscribe.Prenumeruoti);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
