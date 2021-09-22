using NUnit.Framework;
using OpenQA.Selenium;

namespace Darbas.Page
{
    public class ShoppingBagPage : BasePage
    {
        private IWebElement resuult => Driver.FindElement(By.LinkText("Faded Short Sleeve T-shirts"));
        IWebElement ProccedToCheckoutButton => Driver.FindElement(By.CssSelector(".standard-checkout > span"));

        public ShoppingBagPage(IWebDriver webdriver) : base(webdriver) { }

        public void VerifyShoppingBagResult()
        {
            Assert.That(resuult.Text, Is.EqualTo("Faded Short Sleeve T-shirts"));
            ProccedToCheckoutButton.Click();
        }
       
    }
}


