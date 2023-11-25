using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class SellYourBook
    {

        public static void ClickButtonDeclineCookies()
        {
            Common.ClickElement(Locators.Login.ButtonDeclineCookies);
        }
        public static void ClickManoPaskyra()
        {
            Common.ClickElement(Locators.SellYourBook.ManoPaskyra);
        }

        public static void ClickPradeti()
        {
            Common.ClickElement(Locators.SellYourBook.Pradeti);
        }

        public static void ClickPradetiPrekyba()
        {
            Common.ClickElement(Locators.SellYourBook.PradetiPrekyba);
        }

        public static void ClickSkaitytosKnygos()
        {
            Common.ClickElement(Locators.SellYourBook.SkaitytosKnygos);
        }
    }
}
