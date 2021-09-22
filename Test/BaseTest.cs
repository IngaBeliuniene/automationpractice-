using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Darbas.Driver;
using Darbas.Page;
using Darbas.Tools;

namespace Darbas.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static HomePage _HomePage;
        public static SearchByTextResultPage _SearchResultPage;
        public static ShoppingBagPage _ShoppingBagPage;
        public static PersonalInformationPage _PersonalInformationPage;
        public static OrderConfirmationPage _OrderConfirmationPage;
      

        public static BaseTest baseTest;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetIncognitoChrome1();
        
            _HomePage = new HomePage(driver);
            _SearchResultPage = new SearchByTextResultPage(driver);
            _ShoppingBagPage = new ShoppingBagPage(driver);
            _PersonalInformationPage = new PersonalInformationPage(driver);
            _OrderConfirmationPage = new OrderConfirmationPage(driver);
            
        }
        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.TakeScreeshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
