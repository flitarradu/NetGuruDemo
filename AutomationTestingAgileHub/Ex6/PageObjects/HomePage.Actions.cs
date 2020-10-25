using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.PageObjects
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
            authenticationButton.Click();
        }

        public void AddToCart(IWebElement element)
        {
            element.Click();
            addToCartButton.Click();
        }

        public void ClickEveryMenu()
        {
            laptopuriButton.Click();
            telefoaneButton.Click();
            fotoButton.Click();
            cartiButton.Click();
            accesoriiButton.Click();

        }

    }
}
