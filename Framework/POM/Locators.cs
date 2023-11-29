﻿namespace Framework.POM
{
    internal class Locators
    {
        internal class Login
        {
            internal static string ButtonDeclineCookies = "//*[@aria-label='deny cookies']";
            internal static string PrisijungtiRegistruotis = "(//*[@class='text d-none d-lg-block'])[2]";
            internal static string InputElPastoAdresas = "//*[@id='emailInput']";
            internal static string InputSlaptazodis = "//*[@id='passwordInput']";
            internal static string Prisijungti = "//*[@value='Prisijungti']";
            internal static string ManoPaskyra = "(//*[@href='https://www.knygos.lt/user/personal-data'])[2]";
            internal static string OutputLoginTitle = "//*[@class='col-9 d-flex align-items-center']";

        }
        internal class ProductList
        {
            internal static string VisosKnygos = "//*[@id='all-products']";
            internal static string GrozineLiteratura = "//*[@id='grozine-literatura']/..";
            internal static string Klasika = "//*[@id='filter-desktop']//*[text()='Klasika']";
            internal static string Book = "//a[@data-cta-name='Nežudyk strazdo giesmininko']/..";
            internal static string OutputPirktiTitle = "//*[@id='add_to_cart_single_add_to_cart_book2']";
            internal static string InputBookName = "//*[@id='product-search']";
            internal static string Search = "//*[@class='ico-search']";
            internal static string ToBook = "(//*[@data-cta-product-id='15534400'])[1]";
            internal static string HeartIcon = "//*[contains(@class,'single-product-wrapper')]//*[@id='wishlist-action']";
            internal static string RedHeartIcon = "(//*[@class='btn btn-outline-secondary wish-list-btn active'])[2]";


        }
        internal class Subscribe
        {
            internal static string InputElPastoAdresas = "//*[@id='mce-EMAIL']";
            internal static string SutinkuGautiBendroPobudzioLaiskus = "//*[@id='gdpr_1']";
            internal static string SutinkuGautiPasiulymusIrPaklausimus = "//*[@id='gdpr_9']";
            internal static string Prenumeruoti = "//*[@id='mc-embedded-subscribe']";
            internal static string Advertising = "//*[@id='bottom-bar']//*[@class='close']";
            internal static string OutputSubscribeTitle = "//*[@id='templateBody']/h2";
        }
        internal class SellYourBook
        {
            internal static string ManoPaskyra = "//*[@class='d-none d-xl-flex']";
            internal static string SkaitytosKnygos = "(//*[@href='https://www.knygos.lt/user/skaitytu-knygu-pristatymas'])[2]";
            internal static string PradetiPrekyba = "//*[@href='https://www.knygos.lt/user/skaitytos-knygos-pasirinkite-pardavimo-buda']";
            internal static string Pradeti = "//*[@class='card option-button text-center']";
            internal static string OutputSellYourBookTitle = "//*[contains(@class,'alert-info')]";

        }
    }
}
