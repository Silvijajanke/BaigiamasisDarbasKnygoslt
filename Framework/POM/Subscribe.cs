

using OpenQA.Selenium;
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
            //((IJavaScriptExecutor)driver).
            //Common.ScrollBy("window.scrollBy(0, 300)");
            //System.Threading.Thread.Sleep(1000);
            Common.ScrollBy(0, 6000);
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
    }
}
