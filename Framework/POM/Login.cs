﻿
using System;

namespace Framework.POM
{
    public class Login
    {
        public static void ClickButtonDeclineCookies()
        {
            Common.ClickElement(Locators.Login.ButtonDeclineCookies);
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

        public static void Open()
        {
            Driver.OpenPage("https://www.knygos.lt/");
        }
        public static string GetLoginTitle()
        {
            return Common.GetElementText(Locators.Login.OutputLoginTitle);
        }

        public static void ClickManoPaskyra()
        {
            Common.ClickElement(Locators.Login.ManoPaskyra);
        }
    }
}
