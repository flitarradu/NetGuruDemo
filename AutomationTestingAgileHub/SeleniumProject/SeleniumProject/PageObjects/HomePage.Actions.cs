using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObjects
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

        public void AddTshirtToCart()
        {
            homeButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)"); 
            shortSleeveShirtButton.Click();
            System.Threading.Thread.Sleep(2000);
            shortSleeveShirtAddCartButton.Click();

        }
    }

}

