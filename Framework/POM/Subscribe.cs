namespace Framework.POM
{
    public class Subscribe
    {
        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Subscribe.InputElPastoAdresas, ElPastas);
        }
        
        public static void ClickButtonPrenumeruoti()
        {
            Common.ScrollAndClickElement(Locators.Subscribe.Prenumeruoti);
        }

        public static string GetHeading()
        {
            string currentWindowHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParent(currentWindowHandle);

            return Common.GetElementText("//h2");
        }
    }
}
