using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace BddDemo.PageObjects.PageObjects
{
    public abstract class BasePage
    {
        protected WebDriverWait DriverWait;

        private IWebDriver driver;
        public IWebDriver Driver { get; set; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
