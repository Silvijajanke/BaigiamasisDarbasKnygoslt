﻿

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
            Driver.CloseDriver();
        }

        public static void CloseAdvertising()
        {
            Common.ScrollBy(0, 6000);
            System.Threading.Thread.Sleep(1000);
            Common.ClickElement(Locators.Subscribe.Advertising);
        }
        public static string GetSubscribeTitle()
        {
            return Common.GetElementText(Locators.Subscribe.OutputSubscribeTitle);
        }
    }
}
