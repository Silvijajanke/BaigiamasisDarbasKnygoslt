using Framework;
using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTests
    {
        internal class BaseTest
        {
            [SetUp]
            public void SetUp()
            {
                Driver.InitializeDriver();
                Login.Open();
                System.Threading.Thread.Sleep(1000);
                Framework.POM.Login.ClickButtonDeclineCookies();
            }

            [TearDown]
            public void TearDown()
            {
                Driver.QuitDriver();
            }
        }
    }
}
