using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BddDemo.Specflow
{
    public class BeforeAfter
    {
        private IWebDriver _driver;
        public IWebDriver Driver { get => _driver; set => _driver = value; }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
