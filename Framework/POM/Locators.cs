

namespace Framework.POM
{
    internal class Locators
    {
        internal class Login
        {
            internal static string ButtonDeclineCookies = " //*[@class='cc-btn cc-allow']";
            internal static string PrisijungtiRegistruotis = "(//*[@class='text d-none d-lg-block'])[2]";
            internal static string InputElPastoAdresas = "//*[@id='emailInput']";
            internal static string InputSlaptazodis = "//*[@id='passwordInput']";
            internal static string Prisijungti = "//*[@value='Prisijungti']";
            internal static string OutputLoginTitle = "//*[@class='col col-lg-auto user-menu-item auth-profile-menu-item']";

        }
        internal class ProductList
        {
            internal static string VisosKnygos = "//*[@id='all-products']";
            internal static string GrozineLiteratura = "(//*[@class='ico-sm-right-after'])[2]";
            internal static string Klasika = "(//*[@href ='https://www.knygos.lt/lt/knygos/zanras/klasika/'])[2]";
            internal static string Book = "//*[@data-cta-product-id='15534400']";
            internal static string OutputPirktiTitle = "//*[@id='add_to_cart_single_add_to_cart_book2']";
            internal static string InputBookName = "//*[@id='product-search']";
            internal static string Search = "//*[@class='ico-search']";
            internal static string ToBook = "(//*[@data-cta-product-id='15534400'])[1]";
            internal static string HeartIcon = "(//*[@id='wishlist-action'])[2]";


        }
        internal class Subscribe
        {
            internal static string InputElPastoAdresas = "//*[@id='mce-EMAIL']";
            internal static string SutinkuGautiBendroPobudzioLaiskus = "//*[@id='gdpr_1']";
            internal static string GautiPasiulymusIrPaklausimus = "//*[@id='gdpr_9']";
            internal static string Prenumeruoti = "//*[@id='mc-embedded-subscribe']";
        }
        internal class SellYourBook
        {
            internal static string ManoPaskyra = "//*[@class='d-none d-xl-flex']";
            internal static string SkaitytosKnygos = "(//*[@href='https://www.knygos.lt/user/skaitytu-knygu-pristatymas'])[2]";
            internal static string PradetiPrekyba = "//*[@href='https://www.knygos.lt/user/skaitytos-knygos-pasirinkite-pardavimo-buda']";
            internal static string Pradeti = "(//*[@class='btn btn-primary px-5'])[2]";
            internal static string OutputSellYourBookTitle = "//*[@class='mb-lg-5 mx-lg-2 alert alert-info']";

        }
    }
}
