using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Framework.POM
{
    internal class Common
    {
        internal static void OpenPage(string url)
        {
            Driver.GetDriver().Url = url;
        }

        internal static string GetPageTitle()
        {
            return Driver.GetDriver().Title;
        }

        private static IWebElement GetElement(string locator)
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

        internal static void ScrollBy(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }
    }
}
