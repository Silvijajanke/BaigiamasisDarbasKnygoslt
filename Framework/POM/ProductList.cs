using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class ProductList
    {
        public static void ClickBook()
        {
            Common.ClickElement(Locators.ProductList.ClickBook);
        }

        public static void ClickGrozineLiteratura()
        {
            Common.ClickElement(Locators.ProductList.ClickGrozineLiteratura);
        }

        public static void ClickKlasika()
        {
            Common.ClickElement(Locators.ProductList.ClickKlasika);
        }

        public static void ClickVisosKnygos()
        {
            Common.ClickElement(Locators.ProductList.ClickVisosKnygos);
        }

        public static void GetPirktiTitle()
        {
            Common.ClickElement(Locators.ProductList.GetPirktiTitle);
        }
    }
}
