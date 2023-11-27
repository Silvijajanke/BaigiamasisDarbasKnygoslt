

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
        
        public static void ClickButtonPrenumeruoti()
        {
            Common.ClickElement(Locators.Subscribe.Prenumeruoti);
            System.Threading.Thread.Sleep(1000);
        }

        public static void CloseAdvertising()
        {
            Common.ScrollBy(0, 5000);
            System.Threading.Thread.Sleep(1000);
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
    }
}
