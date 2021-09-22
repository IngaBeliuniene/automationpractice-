using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Darbas.Page
{
    public class OrderConfirmationPage : BasePage
    {

       
       private IWebElement Checkbox => Driver.FindElement(By.Id("cgv"));

        private IWebElement ProccedToCheckoutButton =>Driver.FindElement(By.CssSelector(".standard-checkout > span"));
      
        private IWebElement ByChecqueButton => Driver.FindElement(By.LinkText("Pay by check (order processing will be longer)"));
  
        private IWebElement FinisOrderButton => Driver.FindElement(By.CssSelector("#cart_navigation span"));
        private IWebElement FinishByBankPayButton => Driver.FindElement(By.LinkText("Pay by bank wire (order processing will be longer)"));

        public OrderConfirmationPage(IWebDriver webdriver) : base(webdriver) { }

        public void FinishorderByCheck()
        {
            Checkbox.Click();
            ProccedToCheckoutButton.Click();
            ByChecqueButton.Click();
            FinisOrderButton.Click();
        }
        public void FinishorderByBank()
        {
            Checkbox.Click();
            ProccedToCheckoutButton.Click();
            FinishByBankPayButton.Click();
            FinisOrderButton.Click();

        }

    }












       

        //
       
    
    
         ////////////////////////// banku
        ///
        /// 
        /// 
        ///Driver.FindElement(By.LinkText("Pay by bank wire (order processing will be longer)")).Click();
        // 41 | click | css=#cart_navigation span | 
        //Driver.FindElement(By.CssSelector("#cart_navigation span")).Click();
    }

