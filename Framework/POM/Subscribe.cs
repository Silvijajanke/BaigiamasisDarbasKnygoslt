

using System;

namespace Framework.POM
{
    public class Subscribe
    {
        public static void EnterElPastoAdresas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Subscribe.InputElPastoAdresas, ElPastas);
        }
        public static void ClickSutinkuGautiBendroPobudzioLaiskus()
        {
            Common.ClickElement(Locators.Subscribe.SutinkuGautiBendroPobudzioLaiskus);
        }
        public static void ClickSutinkuGautiPasiulymusIrPaklausimus()
        {
            Common.ClickElement(Locators.Subscribe.SutinkuGautiPasiulymusIrPaklausimus);
        }
        public static void ClickButtonPrenumeruoti()
        {
            Common.ClickElement(Locators.Subscribe.Prenumeruoti);
        }

        public static void CloseAdvertising()
        {
            
            //Driver.ExecuteJavaScript("window.scrollBy(0, 100)");
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
    }
}
