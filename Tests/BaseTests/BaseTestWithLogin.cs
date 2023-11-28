using NUnit.Framework;

namespace Tests
{
    internal class BaseTestWithLogin : BaseTest
    {
        [SetUp]
        public void Login()
        {
            Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
            Framework.POM.Login.EnterElPastoAdresas("de141488@gmail.com");
            Framework.POM.Login.EnterSlaptazodis("Demo881414");
            Framework.POM.Login.ClickPrisijungti();
            
        }
    }
}
