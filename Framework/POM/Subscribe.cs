

namespace Framework.POM
{
    public class Subscribe
    {
        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Subscribe.EnterElPastoAdresas, ElPastas);
        }
        public static void ClickSutinkuGautiBendroPobudzioLaiskus()
        {
            Common.ClickElement(Locators.Subscribe.ClickSutinkuGautiBendroPobudzioLaiskus);
        }
        public static void ClickSutinkuGautiPasiulymusIrPaklausimus()
        {
            Common.ClickElement(Locators.Subscribe.ClickSutinkuGautiPasiulymusIrPaklausimus);
        }
        public static void ClickButtonPrenumeruoti()
        {
            Common.ClickElement(Locators.Subscribe.ClickButtonPrenumeruoti);
        }
    }
}
