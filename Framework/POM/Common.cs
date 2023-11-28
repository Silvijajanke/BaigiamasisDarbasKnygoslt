using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

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

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            IWebElement element = GetElement(locator);
            return element.GetCssValue(propertyName);
        }
        internal static string GetSellYourBookTitle(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void OpenPage(string url)
        {
            Driver.GetDriver().Url = url;
        }

        internal static string GetPageTitle()
        {
            return Driver.GetDriver().Title;
        }
    }
}
