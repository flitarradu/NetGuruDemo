using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetGuruProject.PageObjects
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

    }
}
