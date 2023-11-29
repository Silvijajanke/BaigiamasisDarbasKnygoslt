using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

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

        internal static void WaitForElementToBeVisisble(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static bool ElementHtmlAttributeContainsValue(string locator, string attributeName, string value)
        {
            return GetElement(locator).GetAttribute(attributeName).Contains(value);
        }

        internal static void WaitForElementHtmlAttributeToContainValue(string locator, string attributeName, string value)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(value));
        }

        internal static void WaitForElementHtmlAttributeToNotContainValue(string locator, string attributeName, string value)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => !d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(value));
        }

        internal static void ScrollToElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollToElement(element);
            actions.Perform();
        }

        internal static void ScrollAndClickElement(string locator)
        {
            IWebElement element = GetElement(locator);

            while (true)
            {
                try
                {
                    element.Click();
                    break;
                }
                catch (ElementClickInterceptedException)
                {
                    ScrollBy(0, 50);
                }
            }
        }

        internal static string GetCurrentWindowHandle()
        {
            return Driver.GetDriver().CurrentWindowHandle;
        }

        internal static List<string> GetWindowHandles()
        {
            return Driver.GetDriver().WindowHandles.ToList();
        }

        internal static void SwitchToWindowByHandle(string handle)
        {
            Driver.GetDriver().SwitchTo().Window(handle);
        }

        internal static void SwitchToNewWindowFromParent(string parentWindowHandles)
        {
            List<string> windowHandles = GetWindowHandles();

            foreach (string windowHandle in windowHandles)
            {
                if (windowHandle != parentWindowHandles)
                {
                    SwitchToWindowByHandle(windowHandle);
                }
            }
        }
    }
}
