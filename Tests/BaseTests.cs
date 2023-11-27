using Framework;
using Framework.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Login.Open();
            System.Threading.Thread.Sleep(1000);
            Login.ClickButtonDeclineCookies();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(fileName);
            }

            Driver.QuitDriver();
        }
    }
}
