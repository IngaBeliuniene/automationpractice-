using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Darbas.Page
{
    public class SearchByTextResultPage : BasePage
    {

        private IWebElement AddToChartButtonIcon => Driver.FindElement(By.CssSelector(".ajax_add_to_cart_button > span")); //.Click();
        private IWebElement OpenItem => Driver.FindElement(By.CssSelector(".product_img_link > .replace-2x"));
        private IWebElement AddToChartButton => Driver.FindElement(By.CssSelector(".exclusive > span"));
        private IWebElement PopupCharButton => Driver.FindElement(By.CssSelector(".button-medium > span"));

        public SearchByTextResultPage(IWebDriver webdriver) : base(webdriver) { }

        public void AddToChart()
        {
            OpenItem.Click();
            AddToChartButton.Click();
        }

        public void VerifyAddToChartResult()
        {
            Assert.That(Driver.FindElement(By.LinkText("Faded Short Sleeve T-shirts")).Text, Is.EqualTo("Faded Short Sleeve T-shirts"));
        }
        public void AddToChartByIcon()
        {
            AddToChart();
            PopupCharButton.Click();
        }


    }
}
