using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTestWithLogin : BaseTest
    {
        [SetUp]
        public void LoginMethod()
        {
            Login.ClickButtonPrisijungtiRegistruotis();
            Login.EnterElPastoAdresas("de141488@gmail.com");
            Login.EnterSlaptazodis("Demo881414");
            Login.ClickPrisijungti();
            
        }
    }
}
