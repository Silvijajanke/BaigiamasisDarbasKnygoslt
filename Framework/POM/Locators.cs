

namespace Framework.POM
{
    internal class Locators
    {
        internal class Login
        {
            internal static string ClickButtonDeclineCookies = " //*[@class='cc-btn cc-allow']";
            internal static string ClickButtonPrisijungtiRegistruotis = "(//*[@class='text d-none d-lg-block'])[2]";
            internal static string EnterElPastoAdresas = "//*[@id='emailInput']";
            internal static string EnterSlaptazodis = "//*[@id='passwordInput']";
            internal static string ClickPrisijungti = "//*[@value='Prisijungti']";
            internal static string GetLoginTitle = "//*[@class='col col-lg-auto user-menu-item auth-profile-menu-item']";

        }
        internal class ProductList
        {
            internal static string ClickVisosKnygos = "//*[@id='all-products']";
            internal static string ClickGrozineLiteratura = "(//*[@class='ico-sm-right-after'])[2]";
            internal static string ClickKlasika = "(//*[@href ='https://www.knygos.lt/lt/knygos/zanras/klasika/'])[2]";
            internal static string ClickBook = "//*[@data-cta-product-id='15534400']";
            internal static string GetPirktiTitle = "//*[@id='add_to_cart_single_add_to_cart_book2']";
        }
    }
}
