using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace Framework.POM
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetLoginTitle(string getLoginTitle)
        {
            return GetElement(getLoginTitle).Text;
        }

        internal static string GetPirktiTitle(string getPirktiTitle)
        {
            return GetElement(getPirktiTitle).Text;
        }

        internal static string GetElement(string outputPirktiTitle, string pirkti)
        {
            return GetElement(outputPirktiTitle).Text;
        }
        internal static void ScrollBy(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        //internal static string GetCssValue(string locator, string propertyName)
        //{
        //    return GetElement(locator).GetCssValue(propertyName);
        //}

    }
}
