using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

            // setam driverul sa stea cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }

        public void AuthenticateUser(string user, string password)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            AuthenticateButton.Click();

        }


    }
}
