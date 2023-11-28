
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        internal static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }
        public static string GetLoginTitle()
        {
            return driver.Title;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
        public static string GetSearchTitle()
        {
            return driver.Title;
        }

        public static string GetPirktiTitle()
        {
            return driver.Title;
        }

        public static string GetSubscribeTitle()
        {
            return driver.Title;
        }

        public static string GetRedHeart()
        {
            return driver.Title;
        }

        public static string GetSellYourBookTitle()
        {
            return driver.Title;
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath);
            return screenshotFilePath;
        }
    }
}
