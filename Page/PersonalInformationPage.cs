using OpenQA.Selenium;
using System.Threading;

namespace Darbas.Page
{
    public class PersonalInformationPage : BasePage
    {

        private IWebElement EmailInputFieldButton => Driver.FindElement(By.Id("email_create"));
        private IWebElement SubbmCreatAnAccountButtonitButton => Driver.FindElement(By.CssSelector("#SubmitCreate > span"));
        private IWebElement GenderButton => Driver.FindElement(By.Id("id_gender1"));
        private IWebElement FirstNamebutton => Driver.FindElement(By.Id("customer_firstname"));
        private IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));
        private IWebElement EmailInputFiel => Driver.FindElement(By.Id("email"));
        private IWebElement PaswwordInputField => Driver.FindElement(By.Id("passwd"));
        private IWebElement AdressInputField => Driver.FindElement(By.Id("address1"));
        private IWebElement CityInputField => Driver.FindElement(By.Id("city"));
        private IWebElement PostcodeInputField => Driver.FindElement(By.Id("postcode"));
        private IWebElement PhonenumberInputField => Driver.FindElement(By.Id("phone_mobile"));


        public PersonalInformationPage(IWebDriver webdriver) : base(webdriver) { }
       
        public void InputEmail(string text)
        {
            EmailInputFieldButton.Click();
            EmailInputFieldButton.SendKeys(text);
            SubbmCreatAnAccountButtonitButton.Click();
            Thread.Sleep(3000);
        }

        public void PersonalInfoInputField(string text, string text2, string text3, string text4, string text5, string text6)
        {
            GenderButton.Click();
            FirstNamebutton.Click();
            FirstNamebutton.SendKeys(text);
            LastName.Click();
            LastName.SendKeys(text2);
            EmailInputFiel.Clear();
            EmailInputFiel.SendKeys(text3);
            PaswwordInputField.Clear();
            PaswwordInputField.SendKeys(text4);
            AdressInputField.Click();
            AdressInputField.SendKeys(text5);
            CityInputField.Click();
            CityInputField.SendKeys(text6);
            Driver.FindElement(By.Id("id_state"));
            {
               IWebElement dropdown = Driver.FindElement(By.Id("id_state"));
                dropdown.FindElement(By.XPath("//option[. = 'Alabama']")).Click();
            }
            
            PostcodeInputField.Click();
            PostcodeInputField.SendKeys("54789");
            PhonenumberInputField.Click();
            PhonenumberInputField.SendKeys("+3706123456");

        }
        public void RegistrationokConfirmation()
        {
            Driver.FindElement(By.CssSelector(".button:nth-child(4) > span")).Click();
        }


            
        }
    }


 

