using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSpecflowBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void EnterCredentials(UserDto user)
        {
            emailTextBox.Click();
            var validUser = user.GetUservalid();
            emailTextBox.SendKeys(validUser.userEmail);
            passwordTextBox.SendKeys(validUser.userPassword);
            submitButton.Click();
        }

        public void EnterCredentials(string user, string password)
        {
            emailTextBox.Click();
            emailTextBox.SendKeys(user);
            passwordTextBox.SendKeys(password);
            submitButton.Click();
        }
    }
}
