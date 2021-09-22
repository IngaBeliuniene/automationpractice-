using NUnit.Framework;
using OpenQA.Selenium;


namespace Darbas.Page
{
    public class HomePage : BasePage
    {
        private const string PageAddress = "http://automationpractice.com/index.php";
        private IWebElement SearchField => Driver.FindElement(By.Id("search_query_top"));

        public HomePage(IWebDriver webdriver) : base(webdriver) { }
        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void SearchByWord(string text)
        {
            SearchField.Click();
            SearchField.SendKeys(text);
            SearchField.SendKeys(Keys.Enter);
        }
        
    }

}
    

