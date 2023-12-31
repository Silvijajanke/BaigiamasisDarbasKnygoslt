﻿using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class SellYourBookTest : BaseTests
    {
        [Test]
        public void SellBook()
        {
            string ElPastas = "de141488@gmail.com";
            string slaptazodis = "Demo881414";
            string uzrasas = "Norėdami parduoti knygas užpildykite informaciją, kuri bus naudojama sutarčiai pasirašyti ir finansinėms operacijoms atlikti.";

            Framework.POM.Login.ClickButtonPrisijungtiRegistruotis();
            Framework.POM.Login.EnterElPastoAdresas(ElPastas);
            Framework.POM.Login.EnterSlaptazodis(slaptazodis);
            Framework.POM.Login.ClickPrisijungti();
            Framework.POM.SellYourBook.ClickManoPaskyra();
            Framework.POM.SellYourBook.ClickSkaitytosKnygos();
            Framework.POM.SellYourBook.ClickPradetiPrekyba();
            Framework.POM.SellYourBook.ClickPradeti();
            string actualResult = Driver.GetSellYourBookTitle();
            Assert.That(Driver.GetSellYourBookTitle(), Is.EqualTo(uzrasas));
        }
    }
}
