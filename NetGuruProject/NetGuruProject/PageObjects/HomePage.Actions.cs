using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NetGuruProject.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void Authenticate()
        {
            signInButton.Click();
        }
    }
}
